package model;

public class UserBO {
	
	UserDAO userDAO = new UserDAO();
	
	public void save(int id, String nome, String senha) {
		User user = new User(id, nome, senha);
		userDAO.save(user);
	}

}
