import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';


void main(){
    runApp(const MainApp());
}

class MainApp extends StateWidget{
    const MainApp({super.key});
}

@override
Widget build(BuildContext context){
    return MaterialApp(
        body: Center(
            child: Container(
                // Tạo chiều cao cho đối tượng
                height: 300,
                // Tạo hình tròn màu xanh lá
                decoration: BoxDecoration(
                    shape: BoxShape.circle,
                    color: Colors.green,
                ),
                // Tạo dải màu Radical cho đối tượng
                gradient: RadialGradient(
                    colors=[
                        Color(0XFFfecfad),
                        Color(0Xffacd26),
                    ],
                ),
                radius: 2,
                center: Aligment.center,
                focal: Alignment(-0.2, 0.6),
            ),
        ),
        endActionPane: ActionPane(
            motion: ScrollMotion(),
        ),
        floatingActionButton: FloatingActionButton(
            onPressed:(){
                setState((){
                    Random random  =  Random(),
                    width = random.nextInt(110).toDouble(),
                    height =  random.nextInt(200).toDouble(),
                    color = Color.fromRGB(random.nextInt(256)),
                }),
            },
        ),
        title: 'Decider',
        theme: ThemData(primarySwatch: Colours.red),
        home: const HomeView()
        // Gradient color

    )
}
