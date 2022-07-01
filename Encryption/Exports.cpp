#define Export __declspec(dllexport)

#include <stdio.h>
#include "Encrypt.h"

extern "C" {
	void Export EncryptFile(const char* fileName, const char* key) { Encrypt::EncryptFile(fileName, key); }
	void Export DecryptFile(const char* fileName, const char* key) { Encrypt::DecryptFile(fileName, key); }
}