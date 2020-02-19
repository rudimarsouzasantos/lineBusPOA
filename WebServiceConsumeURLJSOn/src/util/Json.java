package util;

import java.io.IOException;
import java.util.ArrayList;

import controller.ControllerDAOBusPOA;

public class Json {
	
	String URL = "http://www.poatransporte.com.br/php/facades/process.php?a=nc&p=%&t=o";
	ConsumeJSOn serviceConsumeJSOn = new ConsumeJSOn();
	String sArrayJson[];
	String id, nome, codigo;
	ControllerDAOBusPOA controllerDAOBusPOA = new ControllerDAOBusPOA();
	
	public void readJson() throws IOException {
		
		String responseURL = serviceConsumeJSOn.connectionURL(URL);
		ArrayList<String> arrayListJson = new ArrayList<>();
		ArrayList<String> arrayListJsonFormated = new ArrayList<>();
		
		sArrayJson = responseURL.split("}");
		
		for (int i = 0; i < sArrayJson.length; i++) {
			arrayListJson.add(sArrayJson[i]);
		}
		
		for (int i = 0; i < arrayListJson.size(); i++) {
			
			sArrayJson = arrayListJson.get(i).replace(", ,", "").replace(",{", "").split(",");
			if (sArrayJson.length==1) {
				break;
			}
			
			try {
				
				id = sArrayJson[0].replace("\"id\":\"", "").replace("[{", "").replace("\"", "");
				codigo= sArrayJson[1].replace("\"codigo\":\"", "").replace("\"", "");
				nome = sArrayJson[2].replace("\"nome\":\"", "").replace("\"", "");
				
				arrayListJsonFormated.add(id);
				arrayListJsonFormated.add(codigo);
				arrayListJsonFormated.add(new String (nome.getBytes("UTF-8")));
				
				controllerDAOBusPOA.saveJson(id, codigo, nome);
								
			} catch (Exception e) {
				e.getMessage();
			}
		}
	}
}