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
        title: 'Decider',
        theme: ThemData(primarySwatch: Colours.red),
        home: const HomeView()
    )
}
