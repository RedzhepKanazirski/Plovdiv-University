package uni.fmi.post;

import static org.junit.Assert.assertEquals;

import cucumber.api.PendingException;
import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import uni.fmi.login.model.LoginScreenModel;
import uni.fmi.post.model.PostScreenModel;

public class PostSteps {
//--------------------------------------------------------class iddeeed--------------------------------------------------------------------	
	private PostScreenModel PostScreenModel;

//----------------------------------------------------------------------------------------------------------------------------
	@Given("^Потребителят отваря формата за публикуване\\.$")
	public void openPostForm() throws Throwable {
		PostScreenModel = new PostScreenModel();
	}

	@When("^Въвежда заглавие: \"([^\"]*)\"$")
	public void addHeaderOfTopic(final String title ) throws Throwable {
		PostScreenModel.setTitle(title);
	}

	@When("^Въвежда заглавие на подтема: \"([^\"]*)\"$")
	public void addSubtopic(final String subtopic) throws Throwable {
		PostScreenModel.setSubtopic(subtopic);
	}

	@When("^Въвежда съдържание: \"([^\"]*)\"$")
	public void addContent(final String content) throws Throwable {
		PostScreenModel.setContent(content);
	}

	@When("^Натиска бутона за пуликуване\\.$")
	public void clickPostButton() throws Throwable {
		PostScreenModel.clickPostButton();

	}

	@Then("^Вижда съобщение \"([^\"]*)\"$")
	public void checkMessageOnPost(final String expectedMessageP) throws Throwable {
		   assertEquals(expectedMessageP, PostScreenModel.getMessage());
	}
//----------------------------------------------------------------------------------------------------------------------------	
}
