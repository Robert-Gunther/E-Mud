#ifndef EMUD_SERVER_H
#define EMUD_SERVER_H
#pragma once

#include <boost/asio.hpp>
#include <memory>
#include <string>

namespace emud
{
namespace net
{

using boost::asio::ip::tcp;

class Session 
    : public std::enable_shared_from_this<Session>
{
public:
    Session(tcp::socket socket);

    void start();

private:
    void begin_read();
    void write(const std::string& data);

private:
    tcp::socket m_socket;
    enum { max_length = 1024 };
    char m_data[max_length];
};

class Server
{
  public:
    Server(boost::asio::io_service& io_service, short port);

  private:
    void begin_accept();

  private:
    tcp::acceptor m_acceptor;
    tcp::socket m_socket;
};

}
}

#endif // EMUD_SERVER_H
