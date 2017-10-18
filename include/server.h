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

/**
 * @brief represents a Session between a client and the server
 */
class Session 
    : public std::enable_shared_from_this<Session>
{
public:
    /**
     * @brief creates a new Session to communicate with the specified socket.
     * 
     * @param socket the socket to create a {@code Session} for
     */
    Session(tcp::socket socket);

    /**
     * @brief makes the Session begin listening for data from the Server.
     */
    void start();

    /**
     * @brief sends the specified data to the server
     * 
     * @param data the data to send
     */
    void write(const std::string& data);

private:
    /**
     * @brief makes the Session start listening for data from the Server
     * 
     */
    void begin_read();

private:
    tcp::socket m_socket;
    enum { max_length = 1024 };
    char m_data[max_length];
};

class Server
{
  public:
    /**
     * @brief starts a new Server on the specified port using the specified io_service.
     * 
     * @param io_service the io_service to use for the Server
     * @param port the port to listen on
     */
    Server(boost::asio::io_service& io_service, short port);

  private:
    /**
     * @brief starts listening for connections
     */
    void begin_accept();

  private:
    tcp::acceptor m_acceptor;
    tcp::socket m_socket;
};

}
}

#endif // EMUD_SERVER_H
