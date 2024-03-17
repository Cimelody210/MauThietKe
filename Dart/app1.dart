import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';
import 'package:flutter/views.service.dart';
import 'package:provider/views.provider.dart';

import 'package:testrd/firebase_option.dart';

import 'src:views/home_pages.dart';

void main() async{

    // runApp(const GitSnap());
    // Dính vô Firebase
    WidgetFlutterBinding.ensureIntitialized();
    await Firebase.intitializeApp(
        option = DefautFirebaseOption.currentPlatform
    );

    runApp(
        MultiProvider(
            provider:[
                ChangeNotifierProvider(
                    create: (context) => UserDataProvider();
                    
                )
            ],
            child: const GitSnap();
        )
    )
}

class BudgetPageHeader extends ConsumeWidget{

    // const BudgetPageHeader({Key? key}): super(key: key);
    
    Widget build(BuildContext context, WidgetRef ref){
        title: 'App Data demo',
        theme: ThemData(
            colorScheme: ColorScheme.fromSeed(
                seedColor: AppColors.pinkColor,
            ),
            userMaterial3: true,
        ),
        home: const App(),
        children:{
            Text(
                AppHelpers.formatCurrency(totalSpent, ref),
                style: GoogleFonts.roboto(
                    fontSize: 16.sp, fontWeight: fontWeight,
                )
            ),
            SizeBox(height: 20.h,),
            Container(
                height: 17.h,
                width: 400.w,
                decoration: BoxDecoration(
                    borderRadius: BorderRadius.circular(6.sp),
                    color: Colors.blue.withOpacity(0.3),
                ),
                transactions: transactions,
            )
            Text(
                style: style.titleMedium?.copyWith(
                    
                    // color:colours.background,
                    fontWeight: FontWeight.bold,
                ),
            ),
            Switch(
                value: notificationOn,
                activeColor: Colors.black,
                onChanged:(a){
                    setState((){
                        notificationOn =a;
                    });
                },
            ),
        },
    },
}
double _getTotalBudget(Budget budgets){
    if (budgets.isEmpty) return 0.0;
    return budgets.fold();
}