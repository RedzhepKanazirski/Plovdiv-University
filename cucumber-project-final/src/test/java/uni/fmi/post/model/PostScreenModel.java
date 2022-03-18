package uni.fmi.post.model;

import java.security.MessageDigest;

import uni.fmi.post.service.PostService;

public class PostScreenModel {
	//----------------------------------------------------------------------------------------------------------------------------	

	private String title;
	private String subtopic;
	private String content;
	private String message;
	//----------------------------------------------------------------------------------------------------------------------------	

	public void setTitle(final String title) {
  		this.title = title;
	}

	public void setSubtopic(final String subtopic) {
  		this.subtopic = subtopic;
	}

	public void setContent(final String content) {
  		this.content = content;
	}

	public void clickPostButton() {
		message= PostService.post(title, subtopic, content);	
	}

	public String getMessage() {
		return message;
	}
	//----------------------------------------------------------------------------------------------------------------------------	
}
