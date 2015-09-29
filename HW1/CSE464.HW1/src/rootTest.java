import static org.junit.Assert.*;

import org.junit.Test;

public class rootTest {

	@Test
	//no root
	public void WN1() {
		Roots.calculate_roots(1, 1, 1);
		assertEquals(0.0,Roots.num_roots(),0.01);
	}
	@Test
	//1 root
	public void WN2() {
		Roots.calculate_roots(1, 2, 1);
		assertEquals(1.0,Roots.num_roots(),0.01);
		assertEquals(-1.0,Roots.first_root(),0.01);
	}
	@Test
	//2 roots
	public void WN3() {
		Roots.calculate_roots(1, -2, -3);
		assertEquals(2.0,Roots.num_roots(),0.01);
		assertEquals(3.0,Roots.first_root(),0.01);
		assertEquals(-1.0,Roots.second_root(),0.01);
	}
	
	@Test
	public void WN4() {
		// when a = 0 there is suppose to be one root not 0 root
		//in this case a=0, b=-2,b=-3
		//->-2x-3=-0
		//->-2x=3
		//->x=-3/2
		Roots.calculate_roots(0, -2, -3);
		assertEquals(0.0,Roots.num_roots(),0.01);
	}

}
