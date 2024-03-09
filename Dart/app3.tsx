import React from 'react';
import {Alert, Button, Space} from 'antd';
import {getIcon} from ".../../ultis/getAlertIcon";
import  './Alerts.scss';
type AlertColor = "success" |"error"| "warning"| "info" | "grey";

interface SharedAlertProps{
    color: AlertColor;
    message: string;
    description?: string;
    actionButton?: React.ReactNode;
    customIcon?: React.ReactNode;


}

const SharedAler: React.FC<SharedAlertProps>=  ({
    color,
    message,
});
