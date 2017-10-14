#include <server.h>

#include <iostream>

namespace emud
{
namespace net
{
    
Session::Session(tcp::socket socket)
    : m_socket(std::move(socket))
{
}

void Session::start()
{
    begin_read();
}

void Session::begin_read()
{
    auto self(shared_from_this());

    m_socket.async_read_some(boost::asio::buffer(m_data, max_length),
        [this, self](boost::system::error_code ec, std::size_t length)
        {
           if(!ec) {
               // TODO: Properly read a packet from the stream rather than expecting it to be one continuous chunk of data.
               m_data[length] = 0;
               std::cout << "Received: " << m_data << std::endl;
               write("Thank you for your contribution!");
           } 
        });
}

void Session::write(const std::string& data)
{
    auto self(shared_from_this());

    boost::asio::write(m_socket, boost::asio::buffer(data));
    begin_read();
}

Server::Server(boost::asio::io_service& io_service, short port)
    : m_acceptor(io_service, tcp::endpoint(tcp::v4(), port)),
      m_socket(io_service)
{
    begin_accept();
}

void Server::begin_accept()
{
    m_acceptor.async_accept(m_socket,
    [this](boost::system::error_code ec)
    {
        std::cout << "Waiting for connection" << std::endl;
        if(!ec) {
            std::make_shared<Session>(std::move(m_socket))->start();
            begin_accept();
        } else {
            throw boost::system::system_error(ec);
        }
    });
}

}
}