import 'package:decider/views.home_view.dart';
import 'package:flutter/views.material.dart';


// Use DateUntil class from material to work with dates in flutter

void doWork()
{
    DateTime date = DateTime(2024, 3, 18, 11, 30, 0,0,0);
    DateTimeRange range = DateTimeRange(
        start: DateTime.now(),
        end: DateTime.now().add(Duration(days: 10)),
    );
    // Add date
    // 2024-05-01 00:00:00.000
    DateUtils.addDaysToDate(date, 5);

    // Add month
    DateUtils.addMonthToMonthDate(date, 2);

    DateUtils.dateOnly(date);

    DateUtils.dateOnly(range);

    DateUtils.getDaysInMonth(date.year, date.month);
    DateUtils.isSameDay(date, DateTime.now());
    DateUtils.isSameMonth(date, DateTime.now());

    DateUtils.monthDelta(date, DateTime.now().add(Duration(daysL 30)));
}