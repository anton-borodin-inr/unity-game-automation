import pytest
from alttester import By


@pytest.mark.smoke
def test_main_menu_is_loaded(alt_driver):
    main_menu_panel = alt_driver.wait_for_object(By.NAME, "MainMenuPanel", timeout=10)
    title_text = alt_driver.wait_for_object(By.NAME, "TitleText", timeout=10)
    start_button = alt_driver.wait_for_object(By.NAME, "StartButton", timeout=10)
    assert main_menu_panel.enabled
    assert title_text.get_text() == "MiniCatcher"
    assert start_button.enabled
