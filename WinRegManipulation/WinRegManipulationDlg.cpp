// WinRegManipulationDlg.cpp: 实现文件
//

#include "pch.h"
#include "framework.h"
#include "WinRegManipulation.h"
#include "WinRegManipulationDlg.h"
#include "afxdialogex.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CWinRegManipulationDlg 对话框


CWinRegManipulationDlg::CWinRegManipulationDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_WINREGMANIPULATION_DIALOG, pParent)
	  , keyPath(_T("Software\\WinRegManipulation"))
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CWinRegManipulationDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_STATIC_KEY, keyPath);
}

BEGIN_MESSAGE_MAP(CWinRegManipulationDlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BTN_CREATE_KEY, &CWinRegManipulationDlg::OnBnClickedBtnCreateKey)
	ON_BN_CLICKED(IDC_BTN_READ, &CWinRegManipulationDlg::OnBnClickedBtnRead)
	ON_BN_CLICKED(IDC_BTN_CREATE_SUB_KEY, &CWinRegManipulationDlg::OnBnClickedBtnCreateSubKey)
	ON_BN_CLICKED(IDC_BTN_WRITE, &CWinRegManipulationDlg::OnBnClickedBtnWrite)
END_MESSAGE_MAP()


// CWinRegManipulationDlg 消息处理程序

BOOL CWinRegManipulationDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 设置此对话框的图标。  当应用程序主窗口不是对话框时，框架将自动
	//  执行此操作
	SetIcon(m_hIcon, TRUE); // 设置大图标
	SetIcon(m_hIcon, FALSE); // 设置小图标

	// TODO: 在此添加额外的初始化代码

	return TRUE; // 除非将焦点设置到控件，否则返回 TRUE
}

// 如果向对话框添加最小化按钮，则需要下面的代码
//  来绘制该图标。  对于使用文档/视图模型的 MFC 应用程序，
//  这将由框架自动完成。

void CWinRegManipulationDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 用于绘制的设备上下文

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 使图标在工作区矩形中居中
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 绘制图标
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

//当用户拖动最小化窗口时系统调用此函数取得光标
//显示。
HCURSOR CWinRegManipulationDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CWinRegManipulationDlg::OnBnClickedBtnCreateKey()
{
	HKEY hKey;
	if (ERROR_SUCCESS == RegCreateKey(HKEY_CURRENT_USER, keyPath, &hKey))
		this->MessageBox(_T("创建成功！"), _T("成功"), MB_OK | MB_ICONINFORMATION);
	else
		this->MessageBox(_T("创建失败！"), _T("失败"), MB_OK | MB_ICONERROR);
	RegCloseKey(hKey);
}


void CWinRegManipulationDlg::OnBnClickedBtnRead()
{
	HKEY hKey;
	if (ERROR_SUCCESS != RegOpenKey(HKEY_CURRENT_USER, keyPath, &hKey))
	{
		this->MessageBox(_T("打开注册表失败！请检查键是否已创建！"), _T("错误"), MB_ICONERROR);
		return;
	}

	DWORD size;
	DWORD testDword;
	DWORD type;

	// 读取 DWORD 类型的子键
	type = REG_DWORD;
	RegQueryValueEx(hKey, _T("TestDword"), NULL, &type, (LPBYTE)&testDword, &size);
	// 读取 String 类型的子键
	type = REG_SZ;
	PWCHAR pBuffer;
	RegQueryValueExW(hKey, _T("TestString"), NULL, &type, NULL, &size);
	pBuffer = new WCHAR[size];
	ZeroMemory(pBuffer, size);
	RegQueryValueExW(hKey, _T("TestString"), NULL, &type, (LPBYTE)pBuffer, &size);

	CString tip;
	tip.Format(_T("%d"), testDword);
	this->SetDlgItemTextW(IDC_EDIT_TESTDWORD, tip);
	this->SetDlgItemTextW(IDC_EDIT_TESTSTRING, size == 0 ? _T("") : pBuffer);

	delete pBuffer;
	
	RegCloseKey(hKey);
}


void CWinRegManipulationDlg::OnBnClickedBtnCreateSubKey()
{
	HKEY hKey;
	if (ERROR_SUCCESS != RegOpenKey(HKEY_CURRENT_USER, keyPath, &hKey))
	{
		this->MessageBox(_T("打开主键错误！请确认是否已创建！"), _T("错误"), MB_ICONERROR);
		return;
	}

	HKEY hKeySub;
	if (ERROR_SUCCESS != RegCreateKey(hKey, _T("SubKey"), &hKeySub))
	{
		this->MessageBox(_T("创建子键失败！"), _T("错误"), MB_ICONERROR);
		RegCloseKey(hKey);
		return;
	}
	RegCloseKey(hKey);
	RegCloseKey(hKeySub);
	this->MessageBox(_T("创建子键成功！"), _T("成功"), MB_ICONINFORMATION);
}


void CWinRegManipulationDlg::OnBnClickedBtnWrite()
{
	HKEY hKey;
	if (ERROR_SUCCESS != RegOpenKey(HKEY_CURRENT_USER, keyPath, &hKey))
	{
		this->MessageBox(_T("打开注册表失败！请检查键是否已创建！"), _T("错误"), MB_ICONERROR);
		return;
	}

	CString stringBuffer;
	// 写入 DWORD 类型的子键
	this->GetDlgItemTextW(IDC_EDIT_TESTDWORD, stringBuffer);
	DWORD testDword = _ttoi(stringBuffer);
	RegSetValueEx(hKey, _T("TestDword"),NULL, REG_DWORD, (LPBYTE)&testDword, sizeof(testDword));
	// 写入 String 类型的子键
	this->GetDlgItemTextW(IDC_EDIT_TESTSTRING, stringBuffer);
	RegSetValueEx(hKey, _T("TestString"),NULL, REG_SZ, (LPBYTE)stringBuffer.GetBuffer(), stringBuffer.GetLength() * sizeof(WCHAR));

	RegCloseKey(hKey);
	this->MessageBox(_T("写入完成！"), _T("成功"), MB_ICONINFORMATION);
}
