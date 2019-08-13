// SetClassicTheme.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h" 
#include <iostream>

#define WIN32_LEAN_AND_MEAN

#include <windows.h>
#include <uxtheme.h>
#include <tchar.h>
#include <psapi.h>

using namespace std;

_TCHAR *ProcName;
int OK = 0, Error = 0;
BOOL CALLBACK EnumWindowsProc(HWND hwnd, LPARAM lParam);
BOOL CALLBACK EnumChildWindowsProc(HWND hwnd, LPARAM lParam);

VOID DoAThing(HWND hwnd)
{
	BOOL result = SetWindowTheme(hwnd, L" ", L" ");

	if (result == 0)
	{
		// cout << "0x" << hwnd << " - OK" << endl;
		OK++;
	}
	if (result != 0)
	{
		cout << "0x" << hwnd << " - ERR " << GetLastError() << endl;
		Error++;
	}
}

VOID KekThisWindow(HWND hwnd)
{
	DoAThing(hwnd);
	EnumChildWindows(hwnd, &EnumChildWindowsProc, NULL);
}

BOOL CALLBACK EnumChildWindowsProc(HWND hwnd, LPARAM lParam)
{
	DoAThing(hwnd);
	return TRUE;
}

BOOL CALLBACK EnumWindowsProc(HWND hwnd, LPARAM lParam)
{
	if (ProcName != NULL)
	{
		DWORD proc;
		GetWindowThreadProcessId(hwnd, &proc);

		HANDLE procHandle = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, FALSE, proc);

		if (!procHandle)
		{
			DWORD win32err = GetLastError();
			if (win32err == 5) return TRUE; // ignore...
			cout << "ERROR OpenProcess for PID " << proc << " (win32: " << win32err << ")" << endl;
			Error++;
			return TRUE;
		}

		TCHAR Buffer[MAX_PATH];
		if (GetModuleFileNameEx(procHandle, 0, Buffer, MAX_PATH))
		{
			TCHAR EditedProcName[MAX_PATH] = {};

			_tcscpy_s(EditedProcName, MAX_PATH, TEXT("\\"));
			_tcscat_s(EditedProcName, MAX_PATH, ProcName);

			TCHAR* slash = _tcsrchr(Buffer, '\\');
			if (_tcscmp(slash, EditedProcName) == 0)
				KekThisWindow(hwnd);
		}
		else 
		{
			cout << "Error GetModuleFileNameEx" << endl;
			Error++;
		}


		CloseHandle(procHandle);

		return TRUE;
	}
	else 
	{
		KekThisWindow(hwnd);
		return TRUE;
	}
}

int _tmain(int argc, _TCHAR* argv[])
{
	ProcName = argc >= 2 ? argv[1] : NULL;
	// ProcName = (_TCHAR*)TEXT("notepad.exe");

	if (!EnumWindows(&EnumWindowsProc, NULL))
		cout << "FUCK: Can't call EnumWindows" << endl;

	cout << "Done ================" << endl;
	cout << "OK: " << OK << endl;
	cout << "Errors: " << Error << endl;
}
