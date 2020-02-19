package model;

public class BusPOA {
	
	private String id;
	private String codigo;
	private String nome;	
	
	public BusPOA(String id, String codigo, String nome) {
		super();
		this.id = id;
		this.codigo = codigo;
		this.nome = nome;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getCodigo() {
		return codigo;
	}

	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}
	
	
	

}
