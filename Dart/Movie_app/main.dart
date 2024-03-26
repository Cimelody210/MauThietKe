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
        ),
    );
}

class MovieApp extends StatelessWidget {
    const MovieApp (Key? key); super(key: key);

    @Override
    Widget build(BuildContext context){
        return const MaterialApp(
            debugShowCheckedModeBanner: false,
            home: TicketScreen(),
        )
    }
}