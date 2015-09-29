public class usingRoots
{
  public static void main(String[] args)
  {
     double a=0, b=2, c=1;

     Roots.calculate_roots(a,b,c);
     System.out.println(Roots.num_roots());
	 System.out.println(Roots.first_root());
	 System.out.println(Roots.second_root());


 }
}