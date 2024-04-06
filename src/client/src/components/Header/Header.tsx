import React from 'react';
import classes from './Header.module.css';
import {IoSearch} from "react-icons/io5";
import {RiAccountCircleLine} from "react-icons/ri";
import {AiOutlineShoppingCart} from "react-icons/ai";

const Header = () => {
    return (
        <div className={classes.header}>
            <div className={classes.center}>
                <div className={classes.header_content}>
                    <div>
                        <img alt="logo"/>
                    </div>

                    <div className={classes.search_box}>
                        <div className={classes.search_box__content}>
                            <div className={classes.search_icon}>
                            <span>
                                <IoSearch/>
                            </span>
                            </div>
                            <input className={classes.search_input} placeholder="Find anything..."/>
                        </div>
                    </div>

                    <div className={classes.control_btns}>
                        <button className={classes.control_btn}>
                            <RiAccountCircleLine/>
                            <p className={classes.btn_text}>Sign In</p>
                        </button>
                        <button className={classes.control_btn}>
                            <AiOutlineShoppingCart/>
                            <p className={classes.btn_text}>Cart</p>
                        </button>
                    </div>
                </div>
            </div>

            <div className={classes.header_categories}>
                <ul className={classes.header_categories__list}>
                    <li className={classes.list__item}>Stock</li>
                    <li className={classes.list__item}>Tiles</li>
                    <li className={classes.list__item}>Santechnic</li>
                    <li className={classes.list__item}>Categories</li>
                    <li className={classes.list__item}>Categories</li>
                    <li className={classes.list__item}>Outdoor</li>
                    <li className={classes.list__item}>Sale</li>
                </ul>
            </div>
        </div>
    );
};

export default Header;