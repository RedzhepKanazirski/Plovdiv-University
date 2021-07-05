import java.io.File;
import java.io.FileNotFoundException;
import java.util.*;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import javax.swing.JComboBox;

public class DBHelper {

	public static Connection conn = null;
	
	public static MyModel modelProvince = null;
	public static MyModel modelProvinceJoin = null;
	public static MyModel modelReservoir = null;
	public static MyModel modelReservoirJoin = null;
	public static MyModel modelResponsible = null;
	
	public static MyModel modelProvinceSearch = null;


	public static PreparedStatement stateProvince = null;
	public static PreparedStatement stateProvinceJoin = null;
	public static PreparedStatement stateReservoir = null;
	public static PreparedStatement stateReservoirJoin = null;
	public static PreparedStatement stateResponsible = null;

	public static PreparedStatement stateProvinceSearch = null;

	
	public static ResultSet resultProvince = null;
	public static ResultSet resultProvinceJoin = null;
	public static ResultSet resultReservoir = null;
	public static ResultSet resultReservoirJoin = null;
	public static ResultSet resultResponsible = null;
	
	public static ResultSet resultProvinceSearch = null;

	//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
	public static Connection getConnection() {
		
		try {
			File file = new File("C:\\Users\\Kanazirski\\Desktop\\projectOOP\\src\\textFiles\\connection.txt");
			Scanner scanner = new Scanner(file);
			String connectionString ="", username = "",password="";			
			while(scanner.hasNextLine()) {
				connectionString = scanner.nextLine().trim();
				username = scanner.nextLine().trim();
				password = scanner.nextLine().trim();
			}
			Class.forName("org.h2.Driver");
			conn = DriverManager.getConnection(connectionString,username,password);
			//conn = DriverManager.getConnection("jdbc:h2:C:\\\\Users\\Kanazirski\\\\Desktop\\\\2nd course\\\\3ти семестър\\\\практикум по ООП\\\\DB;AUTO_SERVER=TRUE", "sa", "sa");
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	return conn;	
	}//end method  getConnection()
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public static MyModel getAllDataProvince(){
		
		conn = getConnection();
		try {
			stateProvince = conn.prepareStatement("SELECT * FROM PROVINCE");
			resultProvince = stateProvince.executeQuery();
			modelProvince = new MyModel(resultProvince);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	

		return modelProvince;
	}//end method  getAllData()
  //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public static MyModel getAllDataProvinceSearch(){
		
		conn = getConnection();
		try {
			stateProvinceSearch = conn.prepareStatement("SELECT * FROM PROVINCE");
			resultProvinceSearch = stateProvinceSearch.executeQuery();
			modelProvinceSearch = new MyModel(resultProvinceSearch);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	

		return modelProvinceSearch;
	}//end method  getAllData()
    
  //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public static MyModel getAllDataProvinceJoin(){
		
		conn = getConnection();
		try {
			stateProvinceJoin = conn.prepareStatement("Select reservoir.reservoirid, reservoir.name_reservoir,reservoir.area_reservoir, reservoir.depth, province.name, province.population\r\n"
					+ "from province\r\n"
					+ "join reservoir on reservoir.provinceid = province.id;");
			resultProvinceJoin = stateProvinceJoin.executeQuery();
			modelProvinceJoin = new MyModel(resultProvinceJoin);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	

		return modelProvinceJoin;
	}//end method  getAllData()
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public static MyModel getAllDataReservoirJoin(){
		
		conn = getConnection();
		try {
			stateReservoirJoin = conn.prepareStatement("Select responsible.responsibleid, responsible.fname,responsible.lname, responsible.age,responsible.comment, reservoir.NAME_RESERVOIR, reservoir.depth\r\n"
					+ "from reservoir\r\n"
					+ "join responsible on responsible.reservoirid = reservoir.reservoirid;");
			resultReservoirJoin = stateReservoirJoin.executeQuery();
			modelReservoirJoin = new MyModel(resultReservoirJoin);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	

		return modelReservoirJoin;
	}//end method  getAllData()
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
 public static MyModel getAllDataReservoir(){
		
		conn = getConnection();
		try {
			stateReservoir = conn.prepareStatement("SELECT * FROM Reservoir");
			resultReservoir = stateReservoir.executeQuery();
			modelReservoir = new MyModel(resultReservoir);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	

		return modelReservoir;
	}//end method  getAllData()
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
public static MyModel getAllDataResponsible(){
		
		conn = getConnection();
		try {
			stateResponsible = conn.prepareStatement("SELECT * FROM Responsible");
			resultResponsible = stateResponsible.executeQuery();
			modelResponsible = new MyModel(resultResponsible);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}	

		return modelResponsible;
	}//end method  getAllData()
//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
	 static void fillComboProvince(JComboBox<String> comboProvince) {
		conn = getConnection();
		String sql = "select id, name from province";
		try {
			stateProvince = conn.prepareStatement(sql);
			resultProvince = stateProvince.executeQuery();
			comboProvince.removeAllItems();
			while(resultProvince.next() ) {
				String item = resultProvince.getObject(1).toString() + " "+ resultProvince.getObject(2).toString(); 
				comboProvince.addItem(item);
			}//end while
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}//end method fillCombo()
	//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
	 static void fillComboReservoir(JComboBox<String> comboReservoir) {
			conn = getConnection();
			String sql = "select RESERVOIRID, NAME_RESERVOIR from reservoir";
			try {
				stateReservoir = conn.prepareStatement(sql);
				resultReservoir = stateReservoir.executeQuery();
				comboReservoir.removeAllItems();
				while(resultReservoir.next() ) {
					String item = resultReservoir.getObject(1).toString() + " "+ resultReservoir.getObject(2).toString(); 
					comboReservoir.addItem(item);
				}//end while
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}//end method fillCombo()
	
	//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
	
	//---------------------------------------------------------------------------------------------------------------------------------------------------------------------

}//end
		