import React, {userState} from 'react';
import {userEffect} from 'effect';
import {Alert, Button, Space} from 'antd';
import {getIcon} from ".../../ultis/getAlertIcon";
import {sendAnalytics, entry} from './until';
import  './Alerts.scss';

@Injectable({
    proviedIn: 'root'
})

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
//
export class CartService
{
  protected cartList: Cart[] = []
  constructor(private prod: ProductService) { }
  
  getCartAll() {
    
    return this.cartList
  }
  getInStock(id: number) { 
    
    return this.cartList.find( i=> i.Id == id)?.InStock
    
  }
  addCart(index: number, frmProduct: any){
    let itemCart = this.cartList.filter(i => i.Id == this.prod);
  }
}

const router = [
    { path: '', component: HomeComponent, title: "Home"},
    {
      path: 'product-detail/:id',
      component : ProductDetailComponent,
      title: 'Product Detail',
    },
];
@NgModule( 
    {
      declaration: [
        AppComponent,
        HomeComponent,
        ProductListComponent,
        CartService,
      ]
    }
)


export default Avatar;