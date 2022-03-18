package uni.fmi.comment.model;

import uni.fmi.comment.service.CommentService;

public class CommentScreenModel {
//----------------------------------------------------------------------------------------------------------------	        
	private String content;
	private String message;
//----------------------------------------------------------------------------------------------------------------	        

	public void setContent(final String content) {
		this.content = content;
	}
	
    public void clickPostButton() {
		message = CommentService.addcomment(content);
	}

	public String getMessage() {
		return message;
	}
//----------------------------------------------------------------------------------------------------------------	        	
}
