package uml.models;
import java.util.*;

/**
 * 
 */
public class User {
//--------------------------------------------------class promenlivite----------------------------------------------------------
    private String username;
    private String password;
    private String email;
    private Set<Role> roleS;
    private Set<Topic> topicS;

    /**
     * Default constructor
     */
    public User() {
    	this(null, null, null);
    	
    }
//--------------------------------------------------constructor----------------------------------------------------------
    public User(final String username, final String password) {
    	this(username, password, null);
	}
    
    public User(final String username, final String password, final String email) {
    	this.username = username;
    	this.password = password;
    	this.email = email;
	}

//--------------------------------------------------methods----------------------------------------------------------
	/**
     * @return
     */
    public String getUsername() {
        return username;
    }

    /**
     * @param username 
     * @return
     */
    public void setUsername(String username) {
    	this.username = username;
    }

    /**
     * @return
     */
    public String getPassword() {
        return password;
    }

    /**
     * @param password 
     * @return
     */
    public void setPassword(String password) {
    	this.password = password;
    }

    /**
     * @return
     */
    public String getEmail() {
        return email;
    }

    /**
     * @param email 
     * @return
     */
    public void setEmail(String email) {
    	this.email = email;
    }

    /**
     * @return
     */
    public Set<Role> getRoles() {
        return roleS;
    }

    /**
     * @param roles 
     * @return
     */
    public void setRoles(Set<Role> roles) {
    	this.roleS = roles;
    }

    /**
     * @return
     */
    public Set<Topic> getTopic() {
        return topicS;
    }

    /**
     * @param topics 
     * @return
     */
    public void setTopic(Set<Topic> topics) {
    	this.topicS = topics;
    }
//-------------------------------------------------------END_methods----------------------------------------------------------	        
}