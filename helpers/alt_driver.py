from alttester import AltDriver

HOST = "127.0.0.1"
PORT = 13000

def create_driver():
    return AltDriver(host=HOST, port=PORT)
