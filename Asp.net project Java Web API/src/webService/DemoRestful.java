package webService;

import javax.ws.rs.*;
import javax.ws.rs.core.*;

@Path("/demo")
public class DemoRestful {
	
	@GET
	@Produces(MediaType.TEXT_PLAIN)
	@Path("/helloWorld")
	public String helloWorld() {
		return "hello World!!";
	}
	
	@GET
	@Produces(MediaType.TEXT_HTML)
	@Path("/helloWorldHTML")
	public String helloWorldHTML() {
		return "<b> hello World!! </b>";
	}
	
	@GET
	@Produces(MediaType.TEXT_HTML)
	@Path("/hi/{fullName}")
	public String hi(@PathParam("fullName") String fullname) {
		return "<b> Hello "+fullname+" !! </b>";
	}

}
