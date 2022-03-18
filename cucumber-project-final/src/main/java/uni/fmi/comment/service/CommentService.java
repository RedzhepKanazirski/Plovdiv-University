package uni.fmi.comment.service;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

import uml.models.Comment;

public class CommentService {
//----------------------------------------------------------------------------------------------------------------	        
private static List<Comment> commentpostDB = new ArrayList<>();
private static String[] forbiddenWords = {"bitch","whore","fuck","nigga","nigger"};

//--------------------------------------------------------------------------------------------------------------	
	public static String addcomment(String content) {

		if (content == null || content.isBlank()) {
			return "Неуспешно публикуване";
		}
		
		String[] wordCount = content.split(" ");
		
		if(wordCount.length > 150) {
			return "Надвишавате лимита от символи";
		}
		
		if(containsForbiddenWords(wordCount))
		{
			return "Не може да използвате някои от думите";
		}
		
		final Comment newComment = new Comment(content);
		commentpostDB.add(newComment);
		return "Успешно публикуване";	
	}
//--------------------------------------------------------------------------------------------------------------	
	public static boolean containsForbiddenWords(String[] arr) 
	{
		for(int i = 0; i<arr.length; i++) 
		{
			for(int j = 0; j<forbiddenWords.length; j++)
			{
				if(arr[i].equals(forbiddenWords[j]))
				{
					return true;
				}
			}
		}
		return false;
	}	
//--------------------------------------------------------------------------------------------------------------
}













