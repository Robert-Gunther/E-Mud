#include <iostream>
#include <config.h>
#include <server.h>

int main(int argc, char** argv)
{
    if(argc != 2) {
        std::cerr << "Usage: " << argv[0] << " <port>" << std::endl;
        return 1;
    }

    try {
        boost::asio::io_service io_service;
        emud::net::Server s(io_service, std::atoi(argv[1]));

        std::cout << "Starting E-Mud MockServer v" << VERSION_MAJOR << "." << VERSION_MINOR << "." << VERSION_PATCH  << " on port " << argv[1] << std::endl;    
        io_service.run();
    } catch(std::exception& e) {
        std::cerr << "Exception: " << e.what() << std::endl;
    }
    return 0;
}
