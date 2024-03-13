import React from 'react';
import logo from './logo.svg';
import './App.css';
import BowlerList from './BowlingLeague/BowlerList';
import Header from './Header';

function App() {
  return (
    <div className="App">
      <Header />
      <BowlerList />
    </div>
  );
}

export default App;
