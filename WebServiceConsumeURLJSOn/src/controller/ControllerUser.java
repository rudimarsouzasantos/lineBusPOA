package controller;

import model.UserBO;

public class ControllerUser {
	
	UserBO userBO = new UserBO();

	
	public void saveUser(int id, String nome, String senha) {
		userBO.save(id, nome, senha);
	}

}
