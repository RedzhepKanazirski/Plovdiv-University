package uml.models;
import java.util.*;

/**
 * 
 */
public class Role {
//-----------------------------------------------------------------------------------------------------------------------------	    	
    private String roleCode;
    private Set<User> userS;
//--------------------------------------------------default constructor----------------------------------------------------------	    
    /**
     * Default constructor
     */
    public Role() {
    }
//-------------------------------------------------------methods-------------------------------------------------------------	    

    /**
     * @return
     */
    public String getRoleCode() {
        // TODO implement here
        return roleCode;
    }

    /**
     * @param code 
     * @return
     */
    public void setRoleCode(String code) {
    	this.roleCode = code;
    }

    /**
     * @return
     */
    public Set<User> getUsers() {
        return userS;
    }

    /**
     * @param users 
     * @return
     */
    public void setUsers(Set<User> users) {
    	this.userS = users;
    }
//-------------------------------------------------------END_methods-------------------------------------------------------------	    
  
//--------------------------------------------------overrided methods(compared by roleCode)----------------------------------------------------------
	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((roleCode == null) ? 0 : roleCode.hashCode());
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj) {
			return true;
		}
		if (obj == null) {
			return false;
		}
		if (getClass() != obj.getClass()) {
			return false;
		}
		Role other = (Role) obj;
		if (roleCode == null) {
			if (other.roleCode != null) {
				return false;
			}
		} else if (!roleCode.equals(other.roleCode)) {
			return false;
		}
		return true;
	}
//--------------------------------------------------END overrided methods(compared by roleCode)----------------------------------------------------------


}