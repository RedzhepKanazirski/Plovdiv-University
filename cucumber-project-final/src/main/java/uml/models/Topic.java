package uml.models;
import java.util.*;

/**
 * 
 */
public class Topic {
//--------------------------------------------------------------------------------------------------------------------	    	
    private String title;
    private String subtopic;
    private String content;
    private User owner;
    private Set<Comment> commentS;
//-------------------------------------------------------Default constructor----------------------------------------------	        
    /**
     * Default constructor
     */
    public Topic() {
    }
 //------------------------------------------------------- constructor---------------------------------------------------	        
   
    public Topic(final String title, final String subtopic, final String content) {
    	this.title = title;
    	this.subtopic = subtopic;
    	this.content = content;
	}
//-------------------------------------------------------methods----------------------------------------------------------	        

	/**
     * @return
     */
    public User getOwner() {
        return owner;
    }

    /**
     * @param owner 
     * @return
     */
    public void setOwner(User owner) {
    	this.owner = owner;
    }

    /**
     * @return
     */
    public String getTitle() {
        return title ;
    }

    /**
     * @param title 
     * @return
     */
    public void setTitle(String title) {
    	this.title = title;
    }

    /**
     * @return
     */
    public String getSubtopic() {
        return subtopic;
    }

    /**
     * @param subtopic 
     * @return
     */
    public void setSubtipic(String subtopic) {
    	this.subtopic = subtopic;
    }

    /**
     * @return
     */
    public String getContent() {
        return content;
    }

    /**
     * @param content 
     * @return
     */
    public void setContent(String content) {
    	this.content= content ;
    }

    /**
     * 
     */

    /**
     * @return
     */
    public Set<Comment> getComment() {
        return commentS;
    }

    /**
     * @param comments 
     * @return
     */
    public void setComment(Set<Comment> comments) {
    	this.commentS = comments;
    }
  //-------------------------------------------------------END_methods----------------------------------------------------------	        
}