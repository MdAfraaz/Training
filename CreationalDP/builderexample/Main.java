class Meal{
    private String appetizer;
    private String mainDish;
    private String salad;
    public void getMeal(){
        System.out.println(this.appetizer+this.mainDish+this.salad);
    }
    private Meal(Builder builder){
        this.appetizer = builder.appetizer;
        this.mainDish = builder.mainDish;
        this.salad = builder.salad;
    }
    public static Builder builder(){
        return new Builder();
    }
    static class Builder{
        private String appetizer;
        private String mainDish;
        private String salad;
        
        public Builder appetizer(String appetizer){
            this.appetizer = appetizer;
            return this;
        }
        public Builder mainDish(String mainDish){
            this.mainDish = mainDish;
            return this;
        }
        public Builder salad(String salad){
            this.salad = salad;
            return this;
        }
        
        public Meal build(){
            return new Meal(Builder.this);
        }
    }
}
public class Main{  
 public static void main(String args[]){  
   Meal myMeal = Meal.builder().mainDish("mainDish").salad("salad").build();
   myMeal.getMeal();
 }  
}  


