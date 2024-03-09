import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';
import 'package:flutter/views.service.dart';
import 'package:provider/views.provider.dart';

void main(){
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
    Widget build(BuildContext context, WidgetRef ref){
        children:{
            Text(
                AppHelpers.formatCurrency(totalSpent, ref),
                style: style.titleMedium?.copyWith(
                    color:colours.background,
                ),
            ),
            Text(
                style: style.titleMedium?.copyWith(
                    color:colours.background,
                    fontWeight: FontWeight.bold,
                ),
            ),
        },
    },
}
double _getTotalBudget(Budget budgets){
    if (budgets.isEmpty) return 0.0;
    return budgets.fold();
}