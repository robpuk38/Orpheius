#include "main_browser.h"
using namespace Microsoft::WRL;
//////////////////////////////////////////////////////////
//         place holder for type of definetions 
//START PLACE HOLDER TYPEDEF    
//////////////////////////////////////////////////////////
HWND hWnd, hLogo;
HINSTANCE hInst;
HMENU hMenu, hFileMenu;
HBITMAP hLogoImage, hGeneratedImage;
//////////////////////////////////////////////////////////
//END PLACE HOLDER TYPEDEF
/////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////
//         place holder for type of voids 
//START PLACE HOLDER TYPEVOID    
//////////////////////////////////////////////////////////
void AddMenu(HWND);
void AddControls(HWND);
void LoadEdgeWebHandeler(HWND);
void LoadImages();
void Foo(char* str);

//////////////////////////////////////////////////////////
//END PLACE HOLDER TYPEVOID
//////////////////////////////////////////////////////////

// The main window class name.
static TCHAR szWindowClass[] = _T("DesktopApp");

// The string that appears in the application's title bar.
static TCHAR szTitle[] = _T("Orpheius");




// Forward declarations of functions included in this code module:
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);




// Pointer to WebView window
static wil::com_ptr<IWebView2WebView> webviewWindow;
/**
typedef void(_stdcall* LPEXTFUNCRESPOND)(LPCSTR s);
extern "C"
{
	__declspec(dllexport) void __stdcall Foo(const char *str, LPEXTFUNCRESPOND respond)
	{
		// Input is in the string
		// Put Your Responce in respond
		respond("HELLO");

		MessageBox(NULL, L"" + *str, L"MY FIRST GUI 2", MB_OK);
	}
}
*/


int CALLBACK WinMain(_In_ HINSTANCE hInstance, _In_ HINSTANCE hPrevInstance, _In_ LPSTR lpCmdLine, _In_ int nCmdShow)
{

	//WNDCLASSEX Window_Class = {0};
	//Messagebox displays alert window ugly system gui
	//MessageBox(NULL, L"hi", L"MY FIRST GUI", MB_OK);
	
	
	WNDCLASSEX wcex;

	wcex.cbSize = sizeof(WNDCLASSEX);
	wcex.style = CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc = WndProc;
	wcex.cbClsExtra = 0;
	wcex.cbWndExtra = 0;
	wcex.hInstance = hInstance;
	wcex.hIcon = LoadIcon(hInstance, IDI_APPLICATION);
	wcex.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
	//wcex.hbrBackground = (HBRUSH)(COLOR_WINDOW + 2) 1 white 2 grey 
	// 3 black
	wcex.lpszMenuName = NULL;
	wcex.lpszClassName = szWindowClass;
	wcex.hIconSm = LoadIcon(wcex.hInstance, IDI_APPLICATION);

	if (!RegisterClassEx(&wcex))
	{
		//DO SOMETHING
        return 1;
	}

	
	hInst = hInstance;

	

	
	HWND hWnd = CreateWindow(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 0, 0, NULL, NULL, hInstance, NULL);
	
	
	DWORD dwStyle = GetWindowLong(hWnd, GWL_STYLE+1);
	DWORD dwRemove = WS_CAPTION | WS_SYSMENU | WS_MINIMIZEBOX | WS_MAXIMIZEBOX;
	DWORD dwNewStyle = dwStyle & ~dwRemove;
	SetWindowLong(hWnd, GWL_STYLE, dwNewStyle);
	SetWindowPos(hWnd, NULL, -5, -5, -5, -5, SWP_NOSIZE | SWP_NOMOVE
		| SWP_NOZORDER | SWP_NOACTIVATE | SWP_FRAMECHANGED);
	HDC hDC = GetWindowDC(NULL);
	SetWindowPos(hWnd, NULL, 0, 0, GetDeviceCaps(hDC, HORZRES), GetDeviceCaps(hDC, VERTRES), SWP_FRAMECHANGED);


	if (!hWnd)
	{
		// DO SOMETHING

		return 1;
	}

	
	ShowWindow(hWnd,nCmdShow);
	UpdateWindow(hWnd);
	LoadEdgeWebHandeler(hWnd);
	

	// Main message loop:
	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return (int)msg.wParam;
}


LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{

	
		switch (message)
		{

		case WM_SIZE:
			if (webviewWindow != nullptr)
			{
				RECT bounds;
				GetClientRect(hWnd, &bounds);
				webviewWindow->put_Bounds(bounds);
			};
			break;
		//case EXIT_BUTTON:
			//PostQuitMessage(0);
			//break;
		//case WM_COMMAND:
			//switch (wParam)
			//{
			//case EXIT_BUTTON:
			//	PostQuitMessage(0);
			//	break;
			//default:
			//	break;
			//}
			//break;
		//case WM_CREATE:
			//LoadImages();

			//AddMenu(hWnd);
			//AddControls(hWnd);

			//break;
		//case WM_DESTROY:
			//PostQuitMessage(0);
			//break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
			break;
		}
	
	

	return 0;
}

void AddMenu(HWND hWnd)
{

	//hMenu = CreateMenu();
	//hFileMenu = CreateMenu();
	//AppendMenu(hMenu, MF_POPUP, (UINT_PTR)hFileMenu, L"File");
	//AppendMenu(hFileMenu, MF_STRING, 1, L"New");
	//AppendMenu(hFileMenu, MF_SEPARATOR, NULL, NULL);
	//AppendMenu(hFileMenu, MF_STRING, EXIT_BUTTON, L"Exit");
	//AppendMenu(hMenu, MF_STRING, 2, L"Help");
	//SetMenu(hWnd, hMenu);
}


void AddControls(HWND hWnd)
{
	//WE MIGHT BE ABLE TO USE THIS AS A ADDRESSBAR IF IT WILL STOP DISAPEARING SEEMS TO NEED A Z-INDEX LAYER ON TOP OF ALL OFTHER WINDOWS
	//SINGLE LINE ELEMENT
	//CreateWindow(IP_CLASS_NAME_EDIT, L"...", WS_VISIBLE | WS_POPUP | WS_BORDER | SS_CENTER, 200, 250, 200, 20, hWnd, NULL, NULL, NULL);
	//MUTIABLE LINE ELEMENT
	//CreateWindow(L"Edit", L"...", WS_VISIBLE | WS_POPUP | WS_BORDER | SS_RIGHT | ES_MULTILINE | ES_AUTOVSCROLL, 200, 300, 200, 200, hWnd, NULL, NULL, NULL);
	//CreateWindowW(IP_CLASS_NAME_BUTTON, L"Exit", WS_VISIBLE | WS_POPUP, 10, 300, 80, 25, hWnd, NULL, NULL, NULL);
	//CreateWindow(IP_CLASS_NAME_STATIC, IpWindowName, dwStyle, x_right_left_screen_position, y_up_down_screen_position, width_size, height_size, hWndParent, hMenu, hInstance, IpParam);
	//hLogo = CreateWindowW(L"Static", NULL, WS_VISIBLE | WS_OVERLAPPED | SS_BITMAP, 100, 100, 100, 50, hWnd, NULL, NULL, NULL);
	//SendMessageW(hLogo, STM_SETIMAGE, IMAGE_BITMAP, (LPARAM)hLogoImage);
}




void Foo(char *str)
{
	//do something

	
	MessageBox(NULL, L""+*str, L"MY FIRST GUI", MB_OK);
}

void LoadImages()
{
	//hLogoImage = (HBITMAP)LoadImage(NULL, L"Logo.bmp", IMAGE_BITMAP, 0, 0, LR_LOADFROMFILE);
}

void LoadEdgeWebHandeler(HWND hWnd)
{
	// <-- WebView2 sample code starts here -->
	// Step 3 - Create a single WebView within the parent window
// Known issue - app needs to run on PerMonitorV2 DPI awareness for WebView to look properly
// This is only available on Win10, comment out the line on older OS versions.
	SetProcessDpiAwarenessContext(DPI_AWARENESS_CONTEXT_PER_MONITOR_AWARE_V2);

	// Locate the browser and set up the environment for WebView
	CreateWebView2EnvironmentWithDetails(nullptr, nullptr, nullptr,
		Callback<IWebView2CreateWebView2EnvironmentCompletedHandler>(
			[hWnd](HRESULT result, IWebView2Environment* env) -> HRESULT {

				// Create a WebView, whose parent is the main window hWnd
				env->CreateWebView(hWnd, Callback<IWebView2CreateWebViewCompletedHandler>(
					[hWnd](HRESULT result, IWebView2WebView* webview) -> HRESULT {
						if (webview != nullptr) {
							webviewWindow = webview;
						}

						// Add a few settings for the webview
						// this is a redundant demo step as they are the default settings values
						IWebView2Settings* Settings;
						webviewWindow->get_Settings(&Settings);
						Settings->put_IsScriptEnabled(TRUE);
						Settings->put_AreDefaultScriptDialogsEnabled(TRUE);
						Settings->put_IsWebMessageEnabled(TRUE);

						// Resize WebView to fit the bounds of the parent window
						RECT bounds;
						GetClientRect(hWnd, &bounds);
						webviewWindow->put_Bounds(bounds);

						// Schedule an async task to navigate to Bing
						webviewWindow->Navigate(L"http://127.0.0.1/");



						// Step 4 - Navigation events
						// register an IWebView2NavigationStartingEventHandler to cancel any non-https navigation
						/*EventRegistrationToken token;
						webviewWindow->add_NavigationStarting(Callback<IWebView2NavigationStartingEventHandler>(
							[](IWebView2WebView* webview, IWebView2NavigationStartingEventArgs* args) -> HRESULT {
								PWSTR uri;
								args->get_Uri(&uri);
								std::wstring source(uri);
								if (source.substr(0, 5) != L"https") {
									args->put_Cancel(true);
								}
								CoTaskMemFree(uri);
								return S_OK;
							}).Get(), &token);*/

							// Step 5 - Scripting
							// Schedule an async task to add initialization script that freezes the Object object
						webviewWindow->AddScriptToExecuteOnDocumentCreated(L"Object.freeze(Object);", nullptr);
						// Schedule an async task to get the document URL
						webviewWindow->ExecuteScript(L"window.document.URL;", Callback<IWebView2ExecuteScriptCompletedHandler>(
							[](HRESULT errorCode, LPCWSTR resultObjectAsJson) -> HRESULT {
								LPCWSTR URL = resultObjectAsJson;
								//doSomethingWithURL(URL);
								return S_OK;
							}).Get());

						// Step 6 - Communication between host and web content
						// Set an event handler for the host to return received message back to the web content
						/*webviewWindow->add_WebMessageReceived(Callback<IWebView2WebMessageReceivedEventHandler>(
							[](IWebView2WebView* webview, IWebView2WebMessageReceivedEventArgs* args) -> HRESULT {
								PWSTR message;
								args->get_WebMessageAsString(&message);
								// processMessage(&message);
								webview->PostWebMessageAsString(message);
								CoTaskMemFree(message);
								return S_OK;
							}).Get(), &token);*/

							// Schedule an async task to add initialization script that
							// 1) Add an listener to print message from the host
							// 2) Post document URL to the host
							//webviewWindow->AddScriptToExecuteOnDocumentCreated(
							//	L"window.chrome.webview.addEventListener(\'message\', event => alert(event.data));" \
								L"window.chrome.webview.postMessage(window.document.URL);",
							//	nullptr);

						return S_OK;
					}).Get());
				return S_OK;
			}).Get());


	// <-- WebView2 sample code ends here -->
}