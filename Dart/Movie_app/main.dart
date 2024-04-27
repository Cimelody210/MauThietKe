import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';
import 'package:flutter/views.material.dart';

void main()
{
    runApp(
        MultiProvider(
            providers:[
                ChangeNotifierProvider(
                    creat: (_) => TicketProvider(),
                ),
            ],
            child: const MovieApp(),
        ),
    );
}

class MovieApp extends StatelessWidget {
    int _selectedIndex = 0;
    static const TextStyle optionStyle = TextStyle(fontSize : 30, fontWeight: FontWeight.bold);
    static const List<Widget> _widgetOption = <Widget>[
        Text(
            'Ïndex 1: Business',
            style: optionStyle,
        ),
    ]
    const MovieApp (Key? key); super(key: key);

    @Override
    Widget build(BuildContext context){
        return const MaterialApp(
            debugShowCheckedModeBanner: false,
            home: TicketScreen(),
        )
    }
}