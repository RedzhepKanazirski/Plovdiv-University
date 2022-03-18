package uni.fmi.comment;

import static org.junit.Assert.assertEquals;

import cucumber.api.PendingException;
import cucumber.api.java.en.Given;
import cucumber.api.java.en.Then;
import cucumber.api.java.en.When;
import uni.fmi.comment.model.CommentScreenModel;

public class CommentSteps {
//--------------------------------------------------class promenliva----------------------------------------------------------
		private CommentScreenModel commentModel;

//----------------------------------------------------------------------------------------------------------------------------		
	@Given("^Потребителят отваря формата за коментиране$")
	public void openingDialogComment() throws Throwable {
		commentModel = new CommentScreenModel();
	}

	@When("^Пише коментар: \"([^\"]*)\"$")
	public void addContent(final String content) throws Throwable {
		commentModel.setContent(content);
	}

	@When("^Натиска бутона за пуликуване на коментар$")
	public void clickPostButton() throws Throwable {
		commentModel.clickPostButton();
	}
	
	@Then("^Вижда съобщение \"([^\"]*)\"$")
	public void checkMessageOnComments(final String expectedMessageC) throws Throwable {
		   assertEquals(expectedMessageC, commentModel.getMessage());
	}
//----------------------------------------------------------------------------------------------------------------------------			
}
