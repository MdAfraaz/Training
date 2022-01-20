import java.util.*;
class Sky{
    private static Sky instance;
    private List<String> starNames;
    private Sky(){
        starNames = new ArrayList<String>();
        starNames.add("Hello");
        
    }
    public static synchronized Sky getInstance(){
        if(instance == null){
            instance = new Sky();
        }
        return instance;
    }
    public List<String> getStarNames(){
        return starNames;
    }
}
public class Main
{
	public static void main(String[] args) {
		Sky sky = Sky.getInstance();
		System.out.println(sky.getStarNames());
		
	}
}
