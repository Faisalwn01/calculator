class calculator
{
	static void main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		Console.WriteLineine("hasil penambahan={0}+{1}={2}",a,b,penambahan(a,b));
		Console.WriteLineine("hasil pengurangann={0}-{1}={2}",a,b,pengurangann(a,b));
		
		Console.WriteLineine("Tekan sembarang untuk keluar");
		Console.Readkey();
		
	}
	static int penambahan(int a, int b)
	{
		return a + b;
	}
	static int penambahan(int a, int b)
	{
		return a - b;
	}
}