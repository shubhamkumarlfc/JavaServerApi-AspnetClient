package webService;

import java.util.HashSet;
import java.util.Set;

import javax.ws.rs.core.Application;

@javax.ws.rs.ApplicationPath("rest")
public class ApplicationConfig extends Application{
	
	public Set<Class<?>> getClasses() {
		Set<Class<?>> resources = new HashSet<>();
		addRestResourceClasses(resources);
		return resources;
	}
	
	private void addRestResourceClasses(Set<Class<?>> resources) {
		resources.add(webService.DemoRestful.class);
	}

}
