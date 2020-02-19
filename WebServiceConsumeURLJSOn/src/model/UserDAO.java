package model;

import java.util.ArrayList;

public class UserDAO {
	
	ArrayList<User> arrayListUser;
	
	public UserDAO() {
		arrayListUser = new ArrayList<>();
	}
	
	public void save(User user) {		
		arrayListUser.add(user);
	}
	
	private ArrayList<User> searchAll(){
		return arrayListUser;
	}
	
	public Boolean searchUser(int id) {
		
		if(arrayListUser==null) {
			return false;
		}
		
		for (int i = 0; i < arrayListUser.size(); i++) {	
			if (arrayListUser.get(i).getId()==id) {
				return true;
			}
			else return false;
		}
		return false;
	}
	
public Boolean searchUserNamePass(String nome, String senha) {
		
		if(arrayListUser==null) {
			return false;
		}
		
		for (int i = 0; i < arrayListUser.size(); i++) {	
			if (arrayListUser.get(i).getNome().equals(nome) && arrayListUser.get(i).getSenha().equals(senha)) {
				return true;
			}
		}
		return false;
	}
}
