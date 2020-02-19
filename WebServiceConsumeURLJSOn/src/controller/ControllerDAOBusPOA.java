package controller;

import model.BusPOABO;

public class ControllerDAOBusPOA {
	
	String id, codigo, nome;
	
	BusPOABO busPOABO = new BusPOABO();

	
	public void saveJson(String id, String codigo, String nome) {
		busPOABO.save(id, codigo, nome);
	}

}
