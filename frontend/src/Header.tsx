import React from 'react';

const Header: React.FC = () => {
  const headerStyle: React.CSSProperties = {
    backgroundColor: '#1976D2',
    padding: '20px',
    borderRadius: '8px',
    color: '#FFFFFF',
  };

  const descriptionStyle: React.CSSProperties = {
    fontSize: '16px',
    color: '#FFFFFF',
    fontStyle: 'italic',
  };

  const description =
    'This webpage lists out all of the bowlers and their contact information.';

  const description2 =
    'It contains data from all the bowlers on the Marlins and Sharks teams.';

  return (
    <div style={headerStyle}>
      <h1 className="text-center mb-4">List of Bowlers</h1>
      <div style={descriptionStyle}>{description}</div>
      <div style={descriptionStyle}>{description2}</div>
    </div>
  );
};

export default Header;
