import React from 'react';
import classes from './Footer.module.css';

const Footer = () => {
    return (
        <div className={classes.footer}>
            <div className={classes.content}>
                <div className={classes.content_info}>
                    <h4>Menu</h4>
                    <ul className={classes.list}>
                        <li>Main</li>
                        <li>Shop</li>
                        <li>3D project</li>
                        <li>For partners</li>
                        <li>Payment and delivery</li>
                        <li>About us</li>
                        <li>Contacts</li>
                    </ul>
                </div>
                <div className={classes.content_info}>
                    <h4>Personal account</h4>
                    <ul className={classes.list}>
                        <li>Order history</li>
                        <li>Profile</li>
                        <li>Favourite</li>
                    </ul>
                </div>
                <div className={classes.content_info}>
                    <h4>Contacts</h4>
                    <p>Потрібна консультація?</p>
                    <p>Телефонуйте або пишіть</p>
                    <h5><strong>+38 (050) 759 86 79</strong></h5>
                    <p>магазин "DКераміки"</p>
                    <p>м. Луцьк, вул. Конякіна 18</p>
                    <p><strong>dkeramiku@gmail.com</strong></p>
                </div>
                <div className={classes.work}>
                    <div>
                        <h4>Графік роботи:</h4>
                        <p><strong>ПН-ПТ:</strong> 9:00-19:00</p>
                        <p><strong>СБ:</strong> 10:00-17:00</p>
                        <p><strong>НД:</strong> 10:00-15:00</p>
                    </div>
                    <div>
                        <strong>Платіть за допомогою карти</strong>
                    </div>
                </div>
            </div>
        </div>
    );
};

export default Footer;