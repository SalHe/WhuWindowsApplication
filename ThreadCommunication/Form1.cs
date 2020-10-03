using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ThreadCommunication
{
    public partial class Form1 : Form
    {
        // 产品
        private List<string> productList = new List<string>();
        private int productId = 0;

        // 消费线程数目
        private int currentProducerCount = 0;
        private int currentConsumerCount = 0;

        // 生产锁和消费锁
        private Mutex produceMutex = new Mutex();
        private Mutex consumeLock = new Mutex();

        // 生产信号和消费信号
        private ManualResetEvent allowConsume = new ManualResetEvent(true);
        private ManualResetEvent allowProduce = new ManualResetEvent(true);
        private ManualResetEvent canConsume = new ManualResetEvent(true);


        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewProducer_Click(object sender, EventArgs e)
        {
            Thread threadProducer = new Thread(() =>
            {
                int id = currentProducerCount;
                for (int i = 0; i < 100; i++)
                {
                    lock (produceMutex)
                    {
                        canConsume.Reset();
                        allowProduce.WaitOne();
                        AddProduct($"Product {i + 1} by {id}");
                        Thread.Sleep(50);
                        canConsume.Set();
                    }
                }
            }) {IsBackground = true};
            currentProducerCount++;
            threadProducer.Start();
        }

        private void AddProduct(string product)
        {
            productList.Add(product);
            lbProducts.Invoke((MethodInvoker) delegate
            {
                lbProducts.Items.Add(product);
                lbProducts.TopIndex++;
            });
        }

        private void btnNewConsumer_Click(object sender, EventArgs e)
        {
            Thread threadConsumer = new Thread(() =>
            {
                int id = currentConsumerCount;
                while (allowConsume.WaitOne())
                {
                    canConsume.WaitOne();
                    lock (consumeLock)
                    {
                        if (productId >= productList.Count)
                        {
                            ConsumeProduct("EXIT", $"Consumer {id}");
                            break;
                        }
                        ConsumeProduct(productList[productId], $"Consumer {id}");
                        productId++;
                    }
                }
            }) {IsBackground = true};
            currentConsumerCount++;
            threadConsumer.Start();
        }

        private void ConsumeProduct(string product, string consumer)
        {
            lbConsume.Invoke((MethodInvoker) delegate
            {
                lbConsume.Items.Add($"{consumer} - {product}");
                lbConsume.TopIndex++;
            });
        }

        private void cbCanConsume_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCanConsume.Checked)
                allowConsume.Set();
            else
                allowConsume.Reset();
        }

        private void cbCanProduce_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCanProduce.Checked)
                allowProduce.Set();
            else
                allowProduce.Reset();
        }
    }
}