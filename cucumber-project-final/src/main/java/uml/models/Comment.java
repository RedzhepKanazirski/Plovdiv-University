package uml.models;
import java.util.*;

/**
 * 
 */
public class Comment {
//------------------------------------------------------------------------------------------------------------------	
  private String content;
    
    private Topic topic;
    private Set<Comment> children;
    private Comment parent;
  //--------------------------------------------------default constructor----------------------------------------------------------	    
    /**
     * Default constructor
     * @param content 
     */
    public Comment() {
    	
    }
  //--------------------------------------------------constructor----------------------------------------------------------
    //public Comment(final String content) {
    //	this(content);
	//}
    
  //  public Comment(final String content) {
  //  	this.content = content;
//	}



	public Comment(final String content) {
      this.content= content;
	}	
	//--------------------------------------------------methods----------------------------------------------------------
    /**
     * @return
     */
    public Comment getParent() {
        return parent;
    }

    /**
     * @param parent 
     * @return
     */
    public void setParent(Comment parent) {
      this.parent = parent;
    }

    /**
     * @return
     */
    public Set<Comment> gertChildren() {
        return children;
    }

    /**
     * @param children 
     * @return
     */
    public void setChildren(Set<Comment> children) {
      this.children = children;
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
    	this.content = content;
    }
    
    /**
     * @return
     */
    public Topic getTopic() {
        return topic;
    }

    /**
     * @param topic 
     * @return
     */
    public void setTopic(Topic topic) {
    	this.topic = topic;
    }
//--------------------------------------------------end methods----------------------------------------------------------
}
