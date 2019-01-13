public static class IntExtensions{

    /* Clip to the semi open range [a, b[ */
    public static int Clip(this int x, int start, int end){
        if(x<start)  x = start;
		if(x>=end) x = end-1;
		return x;
    }



}
