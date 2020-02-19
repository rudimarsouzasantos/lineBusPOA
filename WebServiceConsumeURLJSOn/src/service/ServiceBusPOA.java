package service;

import java.util.ArrayList;

import javax.jws.WebMethod;
import javax.jws.WebService;
import model.BusPOADAO;
import model.User;
import model.UserDAO;
import model.BusPOA;
import util.Json;

@WebService
public class ServiceBusPOA {
	
	UserDAO userDAO = new UserDAO();
	
	@WebMethod
	public ArrayList<BusPOA> searchAll() {
		
		startDownloadJson();
		return BusPOADAO.searchAll();
	}
	
	@WebMethod
	public Boolean searchUser(int id) {
				
		return userDAO.searchUser(id);
	}
	
	@WebMethod
	public Boolean searchUserNamePass(String nome, String senha) {
				
		return userDAO.searchUserNamePass(nome, senha);
	}
	
	@WebMethod
	public void registerUser(User user) {
		userDAO.save(user);
	}
	
	private void startDownloadJson() {
		Json json = new Json();
		try {
			json.readJson();
		} catch (Exception ex) {
			ex.getMessage();
		}
	}
}
