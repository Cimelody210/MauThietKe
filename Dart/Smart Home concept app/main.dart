
@override
void paint(Canvas canvas, Size size){
    double centerX =  size.width / 2;
    double centerY =  size.height / 2;
    Paint paint  = Paint()
        ..color = Colors.black
        ..strokeWidth = 2.0
        ..strokeCap = StrokeCap.round;

    Paint path  = Paint();
    double t =0;

    double x =  radius * cos(t);
    double y =  radius * sin(t);
    path.moveTo(x +  centerX, y+ centerY);
    
    while( t <= pi){
        x = radius * cos(t);
        y = radius * sin(t);
        path.lineTo(x+ centerX, y+ centerY);
        t += 0.01;
    }
    canvas.drawPath(path, paint)
}