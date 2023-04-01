import React from 'react';
import { Outlet } from 'react-router-dom';
import Navbar from '../Nav';

//Layout method to create a navbar that is shared across all of the pages
const Layout = () => {
  return (
    <>
      <Navbar />

      <Outlet />
    </>
  );
};

export default Layout;
