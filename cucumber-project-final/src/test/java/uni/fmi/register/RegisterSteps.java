package uni.fmi.register;

import static org.junit.Assert.assertEquals;

import cucumber.api.PendingException;
import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import uni.fmi.register.model.registerScreenModel;

public class RegisterSteps {
//--------------------------------------------------class promenliva----------------------------------------------------------	
	private registerScreenModel registerScreenModel;

//----------------------------------------------------------------------------------------------------------------------------
	@Given("^Потребителят отваря екрана за регистрация на нов потребител$")
	public void openRegisterScreen() throws Throwable {
	   registerScreenModel = new registerScreenModel();
	}

	@When("^Въведе потребителско име: \"([^\"]*)\"$")
	public void addUsername(final String username) throws Throwable {
		registerScreenModel.setUsername(username);
	}

	@When("^Въведе парола: \"([^\"]*)\"$")
	public void addFirstPass(final String password) throws Throwable {
		registerScreenModel.setFirstPassword(password);

	}

	@When("^Въведе повторно парола: \"([^\"]*)\"$")
	public void addSecondPass(final String password) throws Throwable {
		registerScreenModel.setSecondPassword(password);

	}

	@When("^Въведе електронна поща: \"([^\"]*)\"$")
	public void addEmail(final String email) throws Throwable {
		registerScreenModel.setEmail(email);
	}

	@When("^Натисне бутона за регистрация$")
	public void clickRegisterButton() throws Throwable {
		registerScreenModel.clickRegisterButton();
	}

	@Then("^Вижда съобщение \"([^\"]*)\"$")
	public void checkMessage(final String expectedMessage) throws Throwable {
	   assertEquals(expectedMessage, registerScreenModel.getMessage());
	}
//----------------------------------------------------------------------------------------------------------------------------
}
