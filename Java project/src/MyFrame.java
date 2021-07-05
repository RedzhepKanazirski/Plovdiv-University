import java.awt.Color;
import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Iterator;

import javax.swing.GroupLayout;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTabbedPane;
import javax.swing.JTable;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;


public class MyFrame extends JFrame{
	
	
	// -------------------------------------------StuffFff-------------------------------------------------------
	
	JTable tableProvince = new JTable(); 
	JTable tableReservoir = new JTable(); 
	JTable tableResponisble = new JTable(); 
	JTable tableSearch = new JTable(); 

	ResultSet result = null;	
	public static ResultSet resultProvince = null;
	public static ResultSet resultReservoir = null;
	public static ResultSet resultResponsible = null;
	public static ResultSet resultProvinceSearch = null;


    int id= -1;

	JScrollPane scrollerProvince = new JScrollPane(tableProvince);
	JScrollPane scrollerReservoir = new JScrollPane(tableReservoir);
	JScrollPane scrollerResponsible = new JScrollPane(tableResponisble);
	JScrollPane scrollerSearch = new JScrollPane(tableSearch);

    private PreparedStatement stateProvince = null;
    private PreparedStatement stateReservoir = null;
    private PreparedStatement stateResponsible = null;
    private PreparedStatement stateProvinceSearch = null;

    private Connection conn = null;
	// --------------------------------------------------Panes-------------------------------------------
	JTabbedPane tab = new JTabbedPane();
	
	JPanel provinceA = new JPanel();
	  JPanel provinceB = new JPanel();
	  JPanel provinceC = new JPanel();
	  JPanel provinceD = new JPanel();
	  JPanel provinceE = new JPanel();
	  JPanel provinceF = new JPanel();

	JPanel reservoirA = new JPanel();
	  JPanel reservoirB = new JPanel();
	  JPanel reservoirC = new JPanel();
	  JPanel reservoirD = new JPanel();
	  JPanel reservoirE = new JPanel();
	  JPanel reservoirF = new JPanel();


	JPanel responsibleA = new JPanel(); 
	  JPanel responsibleB = new JPanel();
	  JPanel responsibleC = new JPanel();
	  JPanel responsibleD = new JPanel();
	  JPanel responsibleE = new JPanel();
	  JPanel responsibleF = new JPanel();

	JPanel spravkiA = new JPanel();
	  JPanel spravkiB = new JPanel();
	  JPanel spravkiC = new JPanel();
	  JPanel spravkiD = new JPanel();
	  JPanel spravkiE = new JPanel();
	  JPanel spravkiF = new JPanel();
	  JPanel spravkiG = new JPanel();
	  JPanel spravkiH = new JPanel();
	  JPanel spravkiI = new JPanel();
	// --------------------------------------------------Labels------------------------------------------
	JLabel nameL = new JLabel("Име:");
	JLabel areaL = new JLabel("Площ:");
	JLabel populationL = new JLabel("Население:");
	JLabel searchByNameL = new JLabel("Търсене по име:");
	    
	      JLabel emptynesss = new JLabel("");
	      JLabel emptynesss2 = new JLabel("");

	JLabel nameReservoirL = new JLabel("Наименование на водоем:");
	JLabel areaReservoirL = new JLabel("Площ на водоема:");
	JLabel depthReservoirL = new JLabel("Дълбочина на водоема:");
	JLabel addProvinceinReservoirL = new JLabel("Поставете област:");
	JLabel searchByDepthL = new JLabel("Търсене по дълбочина на водоема(над въведената):");

	
	JLabel fnameResponsibleL = new JLabel("Име на отговорника:");
	JLabel lnameResponsibleL = new JLabel("Фамилия на отговорника:");
	JLabel ageResponsibleL = new JLabel("Години на отговотника:");
	JLabel commentResponsibleL = new JLabel("Коментар:");
	JLabel addReservoirinResponsibleL = new JLabel("Назначаване върху водоем:");
	JLabel searchByAgeL = new JLabel("Търсене по години на отговорника(над въведените):");

	JLabel jl = new JLabel();
	JLabel search2L1 = new JLabel("Търсене по 2 критерия :");
	JLabel search2L2 = new JLabel("Търсене по 2 критерия :");
	JLabel searchsearchByDepthL = new JLabel("Търсене по площ(над):");
	JLabel searchsearchByNameL = new JLabel("Търсене по име на област:");
	JLabel searchsearchByDepthReservoirL = new JLabel("Търсене по площ:");
	JLabel searchsearchByNameReservoirL = new JLabel("Търсене по име на провинция:");
	//
	JLabel searchsearchByDepth2L = new JLabel("Търсене по площ(над):");
	JLabel searchsearchByName2L = new JLabel("Търсене по име на провинция:");
	JLabel searchsearchByDepthReservoir2L = new JLabel("Търсене по площ(над):");
	JLabel searchsearchByNameReservoir2L = new JLabel("Търсене по име на провинция:");	//
	
	// --------------------------------------------------TextFields-------------------------------------- 
	JTextField nameTF = new JTextField();
	JTextField areaTF = new JTextField();
	JTextField populationTF = new JTextField();
	JTextField searchByNameProvinceTF = new JTextField();

	JTextField nameReservoirTF = new JTextField();
	JTextField areaReservoirTF = new JTextField();
	JTextField depthReservoirTF = new JTextField();
	JTextField searchByDepthReservoirTF = new JTextField();

	JTextField fnameResponsibleTF = new JTextField();
	JTextField lnameResponsibleTF = new JTextField();
	JTextField ageResponsibleTF = new JTextField();
	JTextField commentResponsibleTF = new JTextField();
	JTextField searchByAgeResponsibleTF = new JTextField();

	JTextField searchSearchBynameProvinceTF = new JTextField();
	JTextField searchSearchBynameReservoirTF = new JTextField();
	//
	//
	// --------------------------------------------------Buttons-----------------------------------------
	JButton addBtnProvince = new JButton("Добавяне");
	JButton deleteBtnProvince = new JButton("Изтриване");
	JButton editBtnProvince = new JButton("Редактиране");
	JButton refreshBtnProvince = new JButton("Опресни");
	JButton searchBtnByName = new JButton("Търси");
	 	
	JButton addBtnReservoir = new JButton("Добавяне");
	JButton deleteBtnReservoir = new JButton("Изтриване");
	JButton editBtnReservoir = new JButton("Редактиране");
	JButton refreshBtnReservoir = new JButton("Опресни");
	JComboBox<String> searchComboProvince = new JComboBox<String>();
	JButton searchBtnByDepth = new JButton("Търси");

	JButton addBtnResponsible = new JButton("Добавяне");
	JButton deleteBtnResponsible = new JButton("Изтриване");
	JButton editBtnResponsible = new JButton("Редактиране");
	JButton refreshBtnResponsible = new JButton("Опресни");
	JComboBox<String> searchComboReservoir = new JComboBox<String>();
	JButton searchBtnByAge = new JButton("Търси");

	JButton searchSearchFirstBtn = new JButton("Търси");
	JButton refreshSearchBtnProvince = new JButton("Опресни");
	// --------------------------------------------------------------------------------------------------
	
	public MyFrame() {
		this.setIconImage(new ImageIcon(getClass().getResource("/images/1.png")).getImage());
		this.setSize(600, 700);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		
		tab.add(provinceA,"Области");
		tab.add(reservoirA,"Водоеми");
		tab.add(responsibleA,"Отговорници");
		tab.add(spravkiA,"Търсене");

		this.add(tab);	
	    this.setLayout(new GridLayout(1,1));
		// --------------------------------------------------ProvincePanel---------------------------------------
	  provinceA.setLayout(new GridLayout(5,2));

	  provinceA.add(provinceB);	  provinceB.setBackground(new Color	  (236, 216, 198));
	  provinceA.add(provinceC);   provinceC.setBackground(new Color	  (236, 216, 198));
	  provinceA.add(provinceD);	  provinceD.setBackground(new Color	  (236, 216, 198));
	  provinceA.add(provinceE);	  provinceE.setBackground(new Color	  (236, 216, 198));
	  provinceA.add(provinceF);	  provinceF.setBackground(new Color	  (236, 216, 198));
 
	  provinceB.setLayout(new GridLayout(3,2));
  //  provinceC.setLayout(new GridLayout(1,5));
	  provinceD.setLayout(new GridLayout(1,1));
      provinceE.setLayout(new GridLayout(3,2));
   // provinceF.setLayout(new GridLayout(1,2));

	  provinceB.add(nameL);
	  provinceB.add(nameTF);
	  provinceB.add(areaL);
	  provinceB.add(areaTF);
	  provinceB.add(populationL);
	  provinceB.add(populationTF);
	    
	  provinceC.add(addBtnProvince);
	  //addBtnProvince.setBackground(Color.#3399ff);
	  addBtnProvince.setBackground(new Color(255, 207, 127));
	  provinceC.add(deleteBtnProvince);
	  deleteBtnProvince.setBackground(new Color(255, 207, 127));
	  provinceC.add(editBtnProvince);
	  editBtnProvince.setBackground(new Color(255, 207, 127));
	  provinceC.add(refreshBtnProvince);
	  refreshBtnProvince.setBackground(new Color(255, 207, 127));

	    addBtnProvince.addActionListener(new AddActionProvince());
	    deleteBtnProvince.addActionListener(new DeleteActionProvince());
	    editBtnProvince.addActionListener(new EditActionProvince());
	    refreshBtnProvince.addActionListener(new RefreshActionProvince());

	    tableProvince.setModel(DBHelper.getAllDataProvince());
	    tableProvince.addMouseListener(new TableListenerProvince());
        provinceD.add(scrollerProvince);
	    scrollerProvince.setPreferredSize(new Dimension(450,180));
	    
	    provinceE.add(searchByNameL);
	    searchByNameL.setHorizontalAlignment(JLabel.CENTER);
	    searchByNameL.setVerticalAlignment(JLabel.CENTER);
	    provinceE.add(searchByNameProvinceTF);
	    provinceE.add(emptynesss);
	    
	    provinceF.add(searchBtnByName);
	    searchBtnByName.addActionListener(new SearchActionProvince());
	    
        tableProvince.getSelectedRow();  
	    //------------------------------------------------ReservoirPannel-----------------------------------
	    reservoirA.setLayout(new GridLayout(5,2));

	    reservoirA.add(reservoirB);	    
	    reservoirB.setBackground(new Color(204, 242, 255));
	    reservoirA.add(reservoirC);	    
	    reservoirA.add(reservoirD);	    
	    reservoirD.setBackground(new Color(204, 242, 255));
	    reservoirA.add(reservoirE);	   
	    reservoirE.setBackground(new Color(204, 242, 255));
	    reservoirA.add(reservoirF);	   
	    reservoirF.setBackground(new Color(204, 242, 255));

	    reservoirB.setLayout(new GridLayout(4,2));
	     //  reservoirC.setLayout(new GridLayout(1,5));
	    reservoirD.setLayout(new GridLayout(1,1));
	    reservoirE.setLayout(new GridLayout(3,2));
	    //  reservoirF.setLayout(new GridLayout(1,5));
	  
	    reservoirB.add(nameReservoirL);
	    reservoirB.add(nameReservoirTF);
	    reservoirB.add(areaReservoirL);
	    reservoirB.add(areaReservoirTF);
	    reservoirB.add(depthReservoirL);
	    reservoirB.add(depthReservoirTF);
	    
	    reservoirB.add(addProvinceinReservoirL);
	    reservoirB.add(searchComboProvince);
        DBHelper.fillComboProvince(searchComboProvince);
	    	   
        reservoirC.add(addBtnReservoir);
        addBtnReservoir.setBackground(new Color (77, 184, 255));
	    reservoirC.add(deleteBtnReservoir);
	    deleteBtnReservoir.setBackground(new Color (0, 122, 204));
	    reservoirC.add(editBtnReservoir);
	    editBtnReservoir.setBackground(new Color (128, 223, 255));
	    reservoirC.add(refreshBtnReservoir);
	    refreshBtnReservoir.setBackground(new Color (240, 240, 236));

	    addBtnReservoir.addActionListener(new AddActionReservoir());
	    deleteBtnReservoir.addActionListener(new DeleteActionReservoir());
	    
	    editBtnReservoir.addActionListener(new EditActionReservoir());
	    refreshBtnReservoir.addActionListener(new RefreshActionReservoir());
	    
	    tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
	  //(do not allow!!!) tableReservoir.setModel(DBHelper.getAllDataReservoir());
	    tableReservoir.addMouseListener(new TableListenerReservoir());
	    
	    reservoirD.add(scrollerReservoir);
	    scrollerReservoir.setPreferredSize(new Dimension(450,180));
	    
	    reservoirE.add(searchByDepthL);
	    searchByDepthL.setHorizontalAlignment(JLabel.CENTER);
	    searchByDepthL.setVerticalAlignment(JLabel.CENTER);
	    reservoirE.add(searchByDepthReservoirTF);
	    reservoirE.add(emptynesss);
	    
	    reservoirF.add(searchBtnByDepth);
	    //reservoirF.add(refreshBtnReservoir);
	    searchBtnByDepth.addActionListener(new SearchActionReservoir());
	    //------------------------------------------------ResponsiblePannel-----------------------------------
	    responsibleA.setLayout(new GridLayout(5,2));

	    responsibleA.add(responsibleB);
	    responsibleA.add(responsibleC);
	    responsibleA.add(responsibleD);
	    responsibleA.add(responsibleE);
	    responsibleA.add(responsibleF);
	    
	    responsibleB.setLayout(new GridLayout(5,2));
	     //  responsibleC.setLayout(new GridLayout(1,5));
	    responsibleD.setLayout(new GridLayout(1,1));
	    responsibleE.setLayout(new GridLayout(3,2));
	    //  responsibleF.setLayout(new GridLayout(1,5));
	   
	    responsibleB.add(fnameResponsibleL);
	    responsibleB.add(fnameResponsibleTF);
	    responsibleB.add(lnameResponsibleL);
	    responsibleB.add(lnameResponsibleTF);
	    responsibleB.add(ageResponsibleL);
	    responsibleB.add(ageResponsibleTF);
	    responsibleB.add(commentResponsibleL);
	    responsibleB.add(commentResponsibleTF);
	    
	    responsibleB.add(addReservoirinResponsibleL);
	   responsibleB.add(searchComboReservoir);
        DBHelper.fillComboReservoir(searchComboReservoir);
	    
	    responsibleC.add(addBtnResponsible);
	    addBtnResponsible.setBackground(new Color  (102, 217, 255));
	    responsibleC.add(deleteBtnResponsible);
	    deleteBtnResponsible.setBackground(new Color  (102, 217, 255));
	    responsibleC.add(editBtnResponsible);
	    editBtnResponsible.setBackground(new Color  (102, 217, 255));
	    responsibleC.add(refreshBtnResponsible);
	    refreshBtnResponsible.setBackground(new Color  (102, 217, 255));

	    
	       addBtnResponsible.addActionListener(new AddActionResponsible());
	       deleteBtnResponsible.addActionListener(new DeleteActionResponsible());
	       editBtnResponsible.addActionListener(new EditActionResponsible());
	       refreshBtnResponsible.addActionListener(new RefreshActionResponsible());
	        
	      //(do not allow!!!) tableResponisble.setModel(DBHelper.getAllDataResponsible());
		    tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
	    tableResponisble.addMouseListener(new TableListenerResponsible());
	    responsibleD.add(scrollerResponsible);
	    scrollerResponsible.setPreferredSize(new Dimension(450,180));
	    
	    responsibleE.add(searchByAgeL);
	    searchByAgeL.setHorizontalAlignment(JLabel.CENTER);
	    searchByAgeL.setVerticalAlignment(JLabel.CENTER);
	    responsibleE.add(searchByAgeResponsibleTF);
	    responsibleE.add(emptynesss);
	    
	    responsibleF.add(searchBtnByAge);
	    searchBtnByAge.setBackground(new Color  (102, 217, 255));
	    searchBtnByAge.addActionListener(new SearchActionResponsible());
	    //----------------------------------------------------------------------------------------------------
	    spravkiA.setLayout(new GridLayout(4,2));

	    spravkiA.add(spravkiB);
	    spravkiA.add(spravkiC);
	    spravkiA.add(spravkiD);
	    spravkiA.add(spravkiE);
	   // spravkiA.add(spravkiF);
	  //  spravkiA.add(spravkiG);
	 //   spravkiA.add(spravkiH);
	  //  spravkiA.add(spravkiI);

	    
	    spravkiB.setLayout(new GridLayout(1,1));
	    spravkiC.setLayout(new GridLayout(3,3));
	  //  spravkiD.setLayout(new GridLayout(1,1));
	   // spravkiE.setLayout(new GridLayout(3,2));
	   // spravkiF.setLayout(new GridLayout(1,1));
	  //  spravkiG.setLayout(new GridLayout(1,1));
	  //  spravkiH.setLayout(new GridLayout(1,1));
	  //  spravkiI.setLayout(new GridLayout(1,1));

	    //jl.setIcon(new ImageIcon("C:\\Users\\Kanazirski\\Desktop\\depositphotos_25575987-stock-photo-water-pool.jpg"));
	    jl.setIcon(new ImageIcon("C:\\Users\\Kanazirski\\Desktop\\projectOOP\\src\\images\\1200px-1_moraine_lake_pano_2019.jpg"));
	    spravkiB.add(jl);
	    validate();
	 //   spravkiB.add(search2L1);
	    search2L1.setHorizontalAlignment(JLabel.CENTER);
	    search2L1.setVerticalAlignment(JLabel.CENTER);
	  
	    
	    spravkiC.add(searchsearchByNameL);
	    spravkiC.add(searchsearchByDepthL);
	    spravkiC.add(searchSearchBynameProvinceTF);
	    spravkiC.add(searchSearchBynameReservoirTF);

        spravkiD.add(searchSearchFirstBtn);
        spravkiD.add(refreshSearchBtnProvince);
        refreshSearchBtnProvince.addActionListener(new RefreshActionProvinceSearch());
     
        spravkiE.add(scrollerSearch);
        scrollerSearch.setPreferredSize(new Dimension(550,120));
        tableSearch.setModel(DBHelper.getAllDataProvinceSearch());
        tableSearch.addMouseListener(new TableListenerProvince());
        
        searchSearchFirstBtn.addActionListener(new SearchActionProvinceSearch());
	    //----------------------------------------------------------------------------------------------------
		this.setVisible(true);
	}//end constructor
	
	public void clearForm() {
		nameTF.setText("");
		areaTF.setText("");
		populationTF.setText("");
		
		nameReservoirTF.setText("");
		areaReservoirTF.setText("");
		depthReservoirTF.setText("");
		
		fnameResponsibleTF.setText("");
		lnameResponsibleTF.setText("");
		ageResponsibleTF.setText("");
		commentResponsibleTF.setText("");
	}//end clearForm
	//-----------------------------------------------------------------------SEARCH---ActionResponsible---------------------------------------------------------
	class SearchActionResponsible implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
           conn = DBHelper.getConnection();
    	   String sql = "select * from responsible where AGE> ? ";
           try {
        	   stateResponsible = conn.prepareStatement(sql);
				stateResponsible.setString(1,searchByAgeResponsibleTF.getText());
				resultResponsible = stateResponsible.executeQuery();
				tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
				tableResponisble.setModel(new MyModel(resultResponsible));

		} catch (Exception e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
			JOptionPane.showMessageDialog(responsibleD, "Моля въведете данни");
		}
			//vikame metoda
			//clearForm();			
		}	
	}//end ADDactionProvince

	//-----------------------------------------------------------------------SEARCH---ActionReservoir---------------------------------------------------------
	class SearchActionReservoir implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
           conn = DBHelper.getConnection();
    	  String sql = "select * from reservoir where Depth> ? ";
              
    	   try {
				stateReservoir = conn.prepareStatement(sql);
				stateReservoir.setString(1,searchByDepthReservoirTF.getText());
				resultReservoir = stateReservoir.executeQuery();
				tableReservoir.setModel(new MyModel(resultReservoir));
			   // tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
		} catch (Exception e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
			JOptionPane.showMessageDialog(reservoirD, "Моля въведете данни");
		}
			//vikame metoda
			//clearForm();			
		}	
	}//end ADDactionProvince

	//-----------------------------------------------------------------------SEARCH---ActionProvince---------------------------------------------------------
	class SearchActionProvince implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
           conn = DBHelper.getConnection();
    	   String sql = "select * from province where name = ?";
           try {
				stateProvince = conn.prepareStatement(sql);
				stateProvince.setString(1,searchByNameProvinceTF.getText());
				resultProvince = stateProvince.executeQuery();
				tableProvince.setModel(new MyModel(resultProvince));
		} catch (Exception e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
			JOptionPane.showMessageDialog(reservoirD, "Моля въведете данни");
		}
			//vikame metoda
			//clearForm();			
		}	
	}//end ADDactionProvince
	
	//-----------------------------------------------------------------------SEARCH---ActionProvinceSEARCHHHHHHHHHHHHHHHHHHHHHHHH---------------------------------------------------------
		class SearchActionProvinceSearch implements ActionListener {

			@Override
			public void actionPerformed(ActionEvent e) {
	           conn = DBHelper.getConnection();
	    	   String sql = "select * from province where name = ? and population >?";
	           try {
					stateProvinceSearch = conn.prepareStatement(sql);
					stateProvinceSearch.setString(1,searchSearchBynameProvinceTF.getText());
					stateProvinceSearch.setString(2,searchSearchBynameReservoirTF.getText());
					resultProvinceSearch = stateProvinceSearch.executeQuery();
					tableSearch.setModel(new MyModel(resultProvinceSearch));
			} catch (Exception e1) {
				// TODO Auto-generated catch block
				//e1.printStackTrace();
				JOptionPane.showMessageDialog(spravkiD, "Моля въведете данни");
			}
				//vikame metoda
				//clearForm();			
			}	
		}//end ADDactionProvince

	
	//--------------------------------------------------------------REFRESH---RefreshActionProvince------------------------------------------------------------------
	class RefreshActionProvince implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {

           conn = DBHelper.getConnection();
       	    tableProvince.setModel(DBHelper.getAllDataProvince());
       	 //   tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
       	    //tableReservoir.setModel(DBHelper.getAllDataReservoir());
    	 //  tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
    	   // tableResponisble.setModel(DBHelper.getAllDataResponsible());    
		}		
	  
	}//end RefreshactionProvince
	//--------------------------------------------------------------REFRESH---RefreshActionProvinceSEARCHHHHHH------------------------------------------------------------------
		class RefreshActionProvinceSearch implements ActionListener {

			@Override
			public void actionPerformed(ActionEvent e) {

	           conn = DBHelper.getConnection();
	       	    tableSearch.setModel(DBHelper.getAllDataProvinceSearch());
	       	 //   tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
	       	    //tableReservoir.setModel(DBHelper.getAllDataReservoir());
	    	 //  tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
	    	   // tableResponisble.setModel(DBHelper.getAllDataResponsible());    
			}		
		  
		}//end RefreshactionProvince
	//--------------------------------------------------------------REFRESH---RefreshActionReservoir------------------------------------------------------------------
		class RefreshActionReservoir implements ActionListener {

			@Override
			public void actionPerformed(ActionEvent e) {

	           conn = DBHelper.getConnection();
			   tableProvince.setModel(DBHelper.getAllDataProvince());
	       	    tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
	       	    //tableReservoir.setModel(DBHelper.getAllDataReservoir());
	    	    //  tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
	    	    // tableResponisble.setModel(DBHelper.getAllDataResponsible());    
			}		
		  
		}//end RefreshactionProvince
		//--------------------------------------------------------------REFRESH---RefreshActionResponsible------------------------------------------------------------------
		class RefreshActionResponsible implements ActionListener {

			@Override
			public void actionPerformed(ActionEvent e) {

	           conn = DBHelper.getConnection();
	   		    tableReservoir.setModel(DBHelper.getAllDataReservoir());
	       	   // tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
	       	    //tableReservoir.setModel(DBHelper.getAllDataReservoir());
	    	      tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
	    	    // tableResponisble.setModel(DBHelper.getAllDataResponsible());    
			}		
		  
		}//end RefreshactionProvince
		//-----------------------------------------------------------------------ADDD---ActionProvince---------------------------------------------------------
		class AddActionProvince implements ActionListener {

			@Override
			public void actionPerformed(ActionEvent e) {
				String nameProvine = nameTF.getText();
			    String areaProvince = areaTF.getText();
				int populationProvince = Integer.parseInt(populationTF.getText()) ;

	           conn = DBHelper.getConnection();
	           try {
	        	   stateProvince = conn.prepareStatement("insert into province values(null,?,?,?);");
	        	   stateProvince.setString(1,nameProvine);
	        	   stateProvince.setString(2, areaProvince);
	        	   stateProvince.setInt(3, populationProvince);

	        	   stateProvince.execute();
	       	    tableProvince.setModel(DBHelper.getAllDataProvince());
	            DBHelper.fillComboProvince(searchComboProvince);

			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}finally {
				try {
					stateProvince.close();
					conn.close();
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					JOptionPane.showMessageDialog(spravkiD, "Моля въведете данни");
					//e1.printStackTrace();
				}		
			}	
				//vikame metoda
				clearForm();			
			}	
		}//end ADDactionProvince		
	//--------------------------------------------------------------ADDD---ActionReservoir------------------------------------------------------------------
	class AddActionReservoir implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
			String nameReservoir = nameReservoirTF.getText();
			String areaReservoir = areaReservoirTF.getText();
			String depthReservoir = depthReservoirTF.getText();
			
			//TableModel modelProvince = tableProvince.getModel();
	     //	int indexs[] = tableProvince.getSelectedRows();
		//	Object[] row = new Object[4];	
		//	DefaultTableModel model1 = (DefaultTableModel) new MyFrame().tableProvince.getModel();
						
	//	for(int i = 0; i<indexs.length;i++) 
	//	{
	//		row[0] = modelProvince.getValueAt(indexs[i],0);
	//		row[1] = modelProvince.getValueAt(indexs[i],1);
		//	row[2] = modelProvince.getValueAt(indexs[i],2);
	//		row[3] = modelProvince.getValueAt(indexs[i],3);

	//		model1.addRow(row);
	//	}
	  	String selectedItemsProvince = searchComboProvince.getSelectedItem().toString();
	     String[] items = selectedItemsProvince.split(" ");
	     int provinceId = Integer.parseInt(items[0]);
	
           conn = DBHelper.getConnection();
           String sql = "insert into reservoir values(null,?,?,?,?)";
           try {
        	   stateReservoir = conn.prepareStatement(sql);
        	   stateReservoir.setString(1, nameReservoir);
        	   stateReservoir.setString(2, areaReservoir);
        	   stateReservoir.setString(3, depthReservoir);
			   stateReservoir.setInt(4, provinceId);	
	        	stateReservoir.execute();

				 id = -1;
   		    tableReservoir.setModel(DBHelper.getAllDataReservoir());
   		    tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
   		    tableProvince.setModel(DBHelper.getAllDataProvince());   
   		   // tableProvince.setModel(DBHelper.getAllDataProvinceJoin());   
		    DBHelper.fillComboProvince(searchComboProvince);
            DBHelper.fillComboReservoir(searchComboReservoir);
		} catch (SQLException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}finally {
			try {
				stateReservoir.close();
				conn.close();
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}		
		}	
			//vikame metoda
			clearForm();			
		}	
	}//end ADDactionReservoir
	
//--------------------------------------------------------------ADDD---ActionResponsible------------------------------------------------------------------
	class AddActionResponsible implements ActionListener {

		@Override
		public void actionPerformed(ActionEvent e) {
			String fnameResponsible = fnameResponsibleTF.getText();
			String lnameResponsible = lnameResponsibleTF.getText();
			 byte ageResponsible; 	
				try {
					ageResponsible = Byte.parseByte(ageResponsibleTF.getText());
				}catch (Exception ex) {
					ageResponsibleTF.setText("грешка - от 0 до 127");
					return;
				}			String commentResponsible = commentResponsibleTF.getText();
		
	  	String selectedItemsReservoir = searchComboReservoir.getSelectedItem().toString();
	     String[] items = selectedItemsReservoir.split(" ");
	     int reservoirId = Integer.parseInt(items[0]);
	
           conn = DBHelper.getConnection();
           String sql = "insert into responsible values(null,?,?,?,?,?)";
           try {
        	   stateResponsible = conn.prepareStatement(sql);
        	   stateResponsible.setString(1, fnameResponsible);
        	   stateResponsible.setString(2, lnameResponsible);
        	   stateResponsible.setByte(3, ageResponsible);
        	   stateResponsible.setString(4, commentResponsible);
        	   stateResponsible.setInt(5, reservoirId);	
        	   stateResponsible.execute();

				 id = -1;
   		    tableResponisble.setModel(DBHelper.getAllDataResponsible());
   		    tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
   		    tableReservoir.setModel(DBHelper.getAllDataReservoir());   
   		   // tableProvince.setModel(DBHelper.getAllDataProvinceJoin());   

		    DBHelper.fillComboReservoir(searchComboReservoir);
		} catch (SQLException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}finally {
			try {
				stateResponsible.close();
				conn.close();
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}		
		}	
			//vikame metoda
			clearForm();			
		}	
	}//end ADDactionReservoir
	//--------------------------------------------------------------EDIT---EditActionProvince------------------------------------------------------------------
	
	class EditActionProvince implements ActionListener {
		
		@Override
		public void actionPerformed(ActionEvent e) {
			String nameProvine = nameTF.getText();
		    String areaProvince = areaTF.getText();
			int populationProvince = Integer.parseInt(populationTF.getText()) ;
			
           conn = DBHelper.getConnection();
    	   String sql = "update province set name=?, area=?,population=? where id=?";

           try {
        	   stateProvince= conn.prepareStatement(sql);
        	   stateProvince.setString(1,nameTF.getText());
        	   stateProvince.setString(2, areaProvince);
        	   stateProvince.setInt(3, populationProvince);
        	   stateProvince.setInt(4, id);
        	   stateProvince.execute();
        	   id = -1;
        	   
		   tableProvince.setModel(DBHelper.getAllDataProvince());
	        DBHelper.fillComboProvince(searchComboProvince);

		   // DBHelper.fillCombo(searchCombo);
		} catch (SQLException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}finally {
			try {
				stateProvince.close();
				conn.close();
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}		
		}
			//vikame metoda
			clearForm();			
		}	
		
	}//end ADDactionReservoir	
	//--------------------------------------------------------------EDIT---EditActionReservoir------------------------------------------------------------------
	
		class EditActionReservoir implements ActionListener {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String nameReservoir = nameReservoirTF.getText();
			    String areaReservoir = areaReservoirTF.getText();
			    String depthReservoir = depthReservoirTF.getText();

	           conn = DBHelper.getConnection();
	    	   String sql = "update reservoir set NAME_RESERVOIR =?, AREA_RESERVOIR =?,DEPTH =? where reservoirid=?";

	           try {
	        	   stateReservoir= conn.prepareStatement(sql);
	        	   stateReservoir.setString(1,nameReservoir);
	        	   stateReservoir.setString(2, areaReservoir);
	        	   stateReservoir.setString(3, depthReservoir);
	        	   stateReservoir.setInt(4, id);
	        	   stateReservoir.execute();
	        	   id = -1;
	        	   
			   tableReservoir.setModel(DBHelper.getAllDataReservoir());
			    tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
		       // DBHelper.fillComboProvince(searchComboProvince);
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}finally {
				try {
					stateReservoir.close();
					conn.close();
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}		
			}
				//vikame metoda
				clearForm();			
			}	
			
		}//end ADDactionReservoir	
	//--------------------------------------------------------------EDIT---EditActionResponsible------------------------------------------------------------------
	
		class EditActionResponsible implements ActionListener {
			
			@Override
			public void actionPerformed(ActionEvent e) {
				String fnameResponsible = fnameResponsibleTF.getText();
			    String lnameResponsible = lnameResponsibleTF.getText();
			    byte age; 	
				try {
					age = Byte.parseByte(ageResponsibleTF.getText());
				}catch (Exception ex) {
					ageResponsibleTF.setText("грешка - от 0 до 127");
					return;
				}			    
				String commentResponsible = commentResponsibleTF.getText();

	           conn = DBHelper.getConnection();
	    	   String sql = "update responsible set fname=?, lname=?,age=?, comment=? where responsibleid=?";
	           try {
	        	   stateResponsible= conn.prepareStatement(sql);
	        	   stateResponsible.setString(1,fnameResponsible);
	        	   stateResponsible.setString(2, lnameResponsible);
	        	   stateResponsible.setByte(3, age);
	        	   stateResponsible.setString(4, commentResponsible);
	        	   stateResponsible.setInt(5, id);
	        	   stateResponsible.execute();
	        	   id = -1;
	        	   
	      	   tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
			   tableResponisble.setModel(DBHelper.getAllDataResponsible());
		        DBHelper.fillComboReservoir(searchComboReservoir);
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				e1.printStackTrace();
			}finally {
				try {
					stateResponsible.close();
					conn.close();
				} catch (SQLException e1) {
					// TODO Auto-generated catch block
					e1.printStackTrace();
				}		
			}
				//vikame metoda
				clearForm();			
			}	
			
		}//end ADDactionReservoir	

//-----------------------------------------------------------TABLE---MOUSELISTENER----Province------------------------------------------------------------------	
	class TableListenerProvince implements MouseListener{

		@Override
		public void mouseClicked(MouseEvent e) {
		
			if(e.getClickCount()==2) 
			{
				JOptionPane.showMessageDialog(rootPane,"You are in mode Edit");
				
				int i = tableProvince.getSelectedRow();
				TableModel model = tableProvince.getModel();
				
				nameTF.setText(model.getValueAt(i, 1).toString());
				areaTF.setText(model.getValueAt(i, 2).toString());
			    populationTF.setText(model.getValueAt(i, 3).toString());
			    
			  	 
			}else 
			  {
				  int row = tableProvince.getSelectedRow();
					id = Integer.parseInt(tableProvince.getValueAt(row,0).toString());
			  }
			
		}

		@Override
		public void mousePressed(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseReleased(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseEntered(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}

		@Override
		public void mouseExited(MouseEvent e) {
			// TODO Auto-generated method stub
			
		}
		
	}//end TableListener

//-----------------------------------------------------------TABLE---MOUSELISTENER----Reservoir------------------------------------------------------------------

		class TableListenerReservoir implements MouseListener{

			@Override
			public void mouseClicked(MouseEvent e) {
				if(e.getClickCount()==2) 
				{
					JOptionPane.showMessageDialog(rootPane,"You are in mode Edit");
					
					int i = tableReservoir.getSelectedRow();
					TableModel model = tableReservoir.getModel();
					
					nameReservoirTF.setText(model.getValueAt(i, 1).toString());
					areaReservoirTF.setText(model.getValueAt(i, 2).toString());
				    depthReservoirTF.setText(model.getValueAt(i, 3).toString());
				    
				  	 
				}else 
				  {
					  int row = tableReservoir.getSelectedRow();
						id = Integer.parseInt(tableReservoir.getValueAt(row,0).toString());
				  }
			}

			@Override
			public void mousePressed(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mouseReleased(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mouseEntered(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}

			@Override
			public void mouseExited(MouseEvent e) {
				// TODO Auto-generated method stub
				
			}
			
		}//end TableListener
	
//-----------------------------------------------------------TABLE---MOUSELISTENER----Responsible------------------------------------------------------------------

				class TableListenerResponsible implements MouseListener{

					@Override
					public void mouseClicked(MouseEvent e) {
						if(e.getClickCount()==2) 
						{
							JOptionPane.showMessageDialog(rootPane,"You are in mode Edit");
							
							int i = tableResponisble.getSelectedRow();
							TableModel model = tableResponisble.getModel();
							
							fnameResponsibleTF.setText(model.getValueAt(i, 1).toString());
							lnameResponsibleTF.setText(model.getValueAt(i, 2).toString());
							ageResponsibleTF.setText(model.getValueAt(i, 3).toString());
						    commentResponsibleTF.setText(model.getValueAt(i, 4).toString());			  	 
						}else 
						  {
							  int row = tableResponisble.getSelectedRow();
								id = Integer.parseInt(tableResponisble.getValueAt(row,0).toString());
						  }
					}

					@Override
					public void mousePressed(MouseEvent e) {
						// TODO Auto-generated method stub
						
					}

					@Override
					public void mouseReleased(MouseEvent e) {
						// TODO Auto-generated method stub
						
					}

					@Override
					public void mouseEntered(MouseEvent e) {
						// TODO Auto-generated method stub
						
					}

					@Override
					public void mouseExited(MouseEvent e) {
						// TODO Auto-generated method stub
						
					}
					
				}//end TableListener
	
//--------------------------------------------------------------DELETE---ActionProvince------------------------------------------------------------------
	class DeleteActionProvince implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
	           conn = DBHelper.getConnection();
			String sql = "delete from province where id=?";
			try {
				stateProvince = conn.prepareStatement(sql);
				//to do fill parameter
				stateProvince.setInt(1, id);
				stateProvince.execute();
				id = -1;
			    tableProvince.setModel(DBHelper.getAllDataProvince());
		        DBHelper.fillComboProvince(searchComboProvince);
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				JOptionPane.showMessageDialog(provinceD, "Грешка");
				//e1.printStackTrace();
			}
		}//end method		
	}//end DeleteAction
	
	//--------------------------------------------------------------DELETE---ActionReservoir------------------------------------------------------------------
	class DeleteActionReservoir implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
	           conn = DBHelper.getConnection();
			String sql = "delete from reservoir where reservoirid=?";
			try {
				stateReservoir = conn.prepareStatement(sql);
				//to do fill parameter
				stateReservoir.setInt(1, id);
				stateReservoir.execute();
				id = -1;
			    tableReservoir.setModel(DBHelper.getAllDataReservoir());
			    tableReservoir.setModel(DBHelper.getAllDataProvinceJoin());
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				JOptionPane.showMessageDialog(reservoirD, "Грешка");
			//	e1.printStackTrace();
			} 
		}//end method		
	}//end DeleteAction
	
	//--------------------------------------------------------------DELETE---ActionResponsible------------------------------------------------------------------
	class DeleteActionResponsible implements ActionListener{

		@Override
		public void actionPerformed(ActionEvent e) {
	           conn = DBHelper.getConnection();
			String sql = "delete from responsible where RESPONSIBLEID =?";
			try {
				stateResponsible = conn.prepareStatement(sql);
				//to do fill parameter
				stateResponsible.setInt(1, id);
				stateResponsible.execute();
				id = -1;
			    tableResponisble.setModel(DBHelper.getAllDataResponsible());
	   		    tableResponisble.setModel(DBHelper.getAllDataReservoirJoin());
			} catch (SQLException e1) {
				// TODO Auto-generated catch block
				JOptionPane.showMessageDialog(responsibleD, "Грешка");
			//	e1.printStackTrace();
			} 
		}//end method		
	}//end DeleteAction
	//------------------------------------------------------------------------------------------------------------------------------------------------------------

}