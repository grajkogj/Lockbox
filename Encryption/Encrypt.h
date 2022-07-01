#pragma once

#include <iostream>
#include <string>
#include <fstream>
#include <stdio.h>


namespace Encrypt {
	extern void EncryptFile(std::string fileName, std::string key);
	extern void DecryptFile(std::string fileName, std::string key);
}