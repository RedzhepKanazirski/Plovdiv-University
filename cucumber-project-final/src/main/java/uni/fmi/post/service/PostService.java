package uni.fmi.post.service;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import uml.models.*;
public class PostService {
//----------------------------------------------------------------------------------------------------------------	        	
	private static List<Topic> topicDB = new ArrayList<>();
	private static String[] forbiddenWords = {"bitch","whore","fuck","fucking","nigga","nigger"};
//--------------------------------------------------------------------------------------------------------------	

	public static String post(String title,String subtopic, String content) {
		String[] wordCount = content.split(" ");
         
		if (content == null || content.isBlank()&& title == null || title.isBlank()) {
			return "Неуспешно публикуване, добавете заглавие и съдържание";
		}
		
		if (content == null || content.isBlank()) 
		{
			if(subtopic == null || subtopic.isBlank())
			{
				return "Неуспешно публикуване, добавете съдържание и ако искате подтема";
			}
		}
		
		if (content == null || content.isBlank()) 
		{
			if(!(subtopic == null))
			{
				return "Неуспешно публикуване, добавете съдържание";
			}
		}
		
		if(onlyNumbers(title)) 
		{
			return "Неуспешно публикуване, не може единствено числа за тема" ;
		}
	
		if(containsForbiddenWords(wordCount))
		{
			return "Неуспешно публикуване, не може да използвате вулгарни думи в съдържанието";
		}
		
		if(title.length() < 4) 
		{
			return "Неуспешно публикуване, не може да публикувате тема с по-малко от 4 символа" ;
		}
		
		final Topic newTopic = new Topic(title,subtopic,content);
		topicDB.add(newTopic);
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
  public static boolean onlyNumbers(String tTtle){
	String numb = "[0-9]+";
	Pattern pattern = Pattern.compile(numb);
	
	if(tTtle == null)
	{
		return false;
	}
	
	Matcher matcher = pattern.matcher(tTtle);
	return matcher.matches();
}
//--------------------------------------------------------------------------------------------------------------	
}
