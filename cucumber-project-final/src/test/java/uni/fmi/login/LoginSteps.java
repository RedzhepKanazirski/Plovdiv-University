package uni.fmi.login;

import static org.junit.Assert.assertEquals;

import cucumber.api.PendingException;
import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import uni.fmi.login.model.LoginScreenModel;

public class LoginSteps {
//--------------------------------------------------class promenliva----------------------------------------------------------
	private LoginScreenModel loginModel;

//----------------------------------------------------------------------------------------------------------------------------	
	@Given("^Отваря екрана за вход в системата\\.$")
	public void openLoginScreen() throws Throwable {
	   loginModel = new LoginScreenModel();
	}

	@When("^Въведе потребителско име: \"([^\"]*)\"\\.$")
	public void addUsername(final String username) throws Throwable {
		loginModel.setUsername(username);
	}

	@When("^въведе валидна потребителска парола\\.$")
	public void addPassword() throws Throwable {
		loginModel.setPassword("a123!red");

	}

	@When("^натисне бутона за вход в системата\\.$")
	public void clickLoginButton() throws Throwable {
		loginModel.clickLoginButton();
	}

	@Then("^Вижда съобщение за успешен вход\\.$")
	public void checkMessage() throws Throwable {
	   assertEquals("Успешно влизане!", loginModel.getMessage());
	}
	
	@Then("^Вижда съобщение за липсващи данни\\.$")
	public void  checkForMissingDataMessage() throws Throwable {
		   assertEquals("Въведете име и парола!", loginModel.getMessage());
	}

	@Then("^Вижда съобщение за грешни данни\\.$")
	public void checkForWrongDataMessage() throws Throwable {
		   assertEquals("Грешни данни!", loginModel.getMessage());
	}
//----------------------------------------------------------------------------------------------------------------------------	

}
