#include <iostream>
#include <memory>

class UnPointer
{
public:
	UnPointer()
	{
		pointer = std::make_unique<int>(10);
		std::cout << "Address: " << pointer.get() << std::endl;
		std::cout << "Value: " << *pointer << std::endl;
		*pointer = 20;
		std::cout << "Address: " << pointer.get() << std::endl;
		std::cout << "Value: " << *pointer << std::endl;
	}

private:
	std::unique_ptr<int> pointer;
};

class ShPointer
{
public:
	ShPointer()
	{
		shpointer = std::make_shared<int>(10);
		std::cout << "Shared Address: " << shpointer.get() << std::endl;
		std::cout << "Shared Value: " << *shpointer << std::endl;
		*shpointer = 20;
		std::cout << "Shared Address: " << shpointer.get() << std::endl;
		std::cout << "Shared Value: " << *shpointer << std::endl;
	}

private:
	std::shared_ptr<int> shpointer;
};


int main()
{
	UnPointer unPointerInstance;
	ShPointer shPointerInstance;
	return 0;
}