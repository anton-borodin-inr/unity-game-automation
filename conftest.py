import pytest
from helpers.alt_driver import create_driver

@pytest.fixture(scope="session")
def alt_driver():
    driver = create_driver()
    yield driver
    driver.stop()