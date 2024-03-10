import React, {userState} from 'react';
import {userEffect} from 'effect';
import {Alert, Button, Space} from 'antd';
import {getIcon} from ".../../ultis/getAlertIcon";
import {sendAnalytics, entry} from './until';
import  './Alerts.scss';
type AlertColor = "success" |"error"| "warning"| "info" | "grey";

function IDtable(){
    const [id, state] = userState(
        [
            {id: 1, name:'Donald Trump', status: false},
            {id: 2, name:'Donald Mc Kinnon', status: false},
            {id: 3, name:'Kinnon', status: false}
        ]);
}
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
const observer = useMemo(()=> new IntersectionObserver(([entry])))
const data_fectch = await fetch('https://');
const toggleStatus = (id)
const Avatar=()=>{
    const dataAnalytics = {pageId:"demo"};
    userEffect(()=>{
        sendAnalytics(dataAnalytics);
        observer=observe(ref.current);
        return ()=> observer.disconnect();
    }, []);
    return <div className = 'tutorial-short'></div>; 
}
export default Avatar;