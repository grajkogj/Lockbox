#include "Encrypt.h"

//very very very bad encryption algorithm. Using it for now just for debuging eveyrthing else and will make it actualy encrypt later

void Encrypt::EncryptFile(std::string fileName, std::string key) {
	std::fstream Old;
	Old.open(fileName, std::ios::in | std::ios::out | std::ios::binary);
	std::fstream File;
	File.open(fileName, std::ios::in | std::ios::out | std::ios::binary);

	char ch;

	while (Old.eof() == false) {
		Old >> ch;
		ch = ch + 100;
		File << ch;
	}

	File.close();
	Old.close();

	return;
}

void Encrypt::DecryptFile(std::string fileName, std::string key) {
	std::fstream Old;
	Old.open(fileName, std::ios::in | std::ios::out | std::ios::binary);
	std::fstream File;
	File.open(fileName, std::ios::in | std::ios::out | std::ios::binary);

	char ch;

	while (Old.eof() == false) {
		Old >> ch;
		ch = ch - 100;
		File << ch;
	}

	File.close();
	Old.close();

	return;
}