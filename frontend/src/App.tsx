import React from 'react';
import './App.css';
import MovieList from './Views/Movies';
import Podcast from './Views/Podcast';
import { Routes, Route } from 'react-router-dom';
import Layout from './Views/Layout';

//App uses the functions Routes and Route are used to create the URL path for each element in the Views folder

//Changed index path to be the MovieList
function App() {
  return (
    <Routes>
      <Route path="/" element={<Layout />}>
        <Route index element={<MovieList />} />

        <Route path="Movies" element={<MovieList />} />

        <Route path="Podcast" element={<Podcast />} />
      </Route>
    </Routes>
  );
}

export default App;
